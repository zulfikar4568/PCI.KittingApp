using Camstar.WCF.ObjectStack;
using Camstar.WCF.Services;
using PCI.KittingApp.Components;
using PCI.KittingApp.Entity;
using PCI.KittingApp.Entity.TransactionFailedType;
using PCI.KittingApp.UseCase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCI.KittingApp.Forms
{
    public partial class FormMaterialRegistration : Form
    {
        // Fields
        private string containerName = null;
        private MaterialRegistration materialRegistrationData = null;
        
        
        private readonly Kitting _kitting;
        private readonly OpcenterCheckData _opcenterCheckData;
        private readonly OpcenterSaveData _opcenterSaveData;
        public FormMaterialRegistration(Kitting kitting, OpcenterCheckData opcenterCheckData, OpcenterSaveData opcenterSaveData)
        {
            InitializeComponent();
            _kitting = kitting;
            _opcenterCheckData = opcenterCheckData;
            _opcenterSaveData = opcenterSaveData;
        }

        private void CheckContainerRegistration()
        {
            // Check Initial Data is Ready or Not
            if (textBoxRegisterContainer.Text == "" || textBoxRegisterContainer.Text == null) return;

            if (materialRegistrationData != null && containerName != null)
            {
                var confirmation = ZIMessageBox.Show($"Currently you still proceed the {containerName}");
            }

            ValidationStatus status = _kitting.ValidateCustomerSerialNumber(textBoxRegisterContainer.Text);
            if (!status.IsSuccess)
            {
                ShowMessage(ErrorCodeMeaning.Translate(status.ErrorCode));
                textBoxRegisterContainer.Clear();
                return;
            }
            containerName = textBoxRegisterContainer.Text.Split('_')[2];
            ValidationStatus isFGValid = _kitting.ValidateFGSerialNumberExists(containerName, _opcenterCheckData.IsContainerExists);
            if (!isFGValid.IsSuccess)
            {
                ShowMessage($"The Container {containerName} {ErrorCodeMeaning.Translate(isFGValid.ErrorCode)}");
                textBoxRegisterContainer.Clear();
                return;
            }

            materialRegistrationData = _opcenterCheckData.ExtractMaterialRequirementFromContainer(containerName);
            if (materialRegistrationData == null) return;
            if (materialRegistrationData.ProductName == null || materialRegistrationData.ERPBOMName == null || materialRegistrationData.BillOfMaterial == null) return;

            textBoxRegisterProduct.Text = materialRegistrationData.ProductName;
            textBoxRegisterERPBOM.Text = materialRegistrationData.ERPBOMName;

            // Clear the Initial materials
            listViewMaterial.Items.Clear();

            var newBOMs = materialRegistrationData.BillOfMaterial;
            GenerateListView(ref newBOMs, listViewMaterial);
            // reassign the new BOM
            materialRegistrationData.BillOfMaterial = newBOMs;

            // Select next field
            textBoxRegisterPN.Select();
        }

        private ListView.ListViewItemCollection GenerateListView(ref BillOfMaterial[] billOfMaterials, ListView owner)
        {
            ListView.ListViewItemCollection listViewItemCollection = new ListView.ListViewItemCollection(owner);
            List<BillOfMaterial> newBOMs = new List<BillOfMaterial>();

            foreach (var item in billOfMaterials)
            {
                if (item == null) continue;
                if (item.IssueControl != IssueControlEnum.Serialized) continue;
                newBOMs.Add(item);

                string[] data = { item.Product, item.Description };
                var listViewItem = new ListViewItem(data)
                {
                    Checked = item.isRegistered
                };
                listViewItemCollection.Add(listViewItem);
            }
            billOfMaterials = newBOMs.ToArray();
            return listViewItemCollection;
        }
        private void ShowMessage(string errorMsg)
        {
            ZIMessageBox.Show(errorMsg, "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CheckPartNumberRegistration()
        {
            // Check Initial Data is Ready or Not
            if (materialRegistrationData == null) return;
            if (materialRegistrationData.BillOfMaterial == null) return;
            if (textBoxRegisterPN.Text == "" || textBoxRegisterPN.Text == null) return;

            ValidationStatus partNumberStatus = _kitting.ValidatePNAssociatedWithERPBOM(textBoxRegisterPN.Text, materialRegistrationData.BillOfMaterial);
            if (!partNumberStatus.IsSuccess)
            {
                ShowMessage(ErrorCodeMeaning.Translate(partNumberStatus.ErrorCode));
                textBoxRegisterPN.Clear();
                return;
            }

            // Select next field
            textBoxRegisterSN.Select();
        }
        private void CheckRegisterSN()
        {
            // Check Initial Data is Ready or Not
            if (containerName == null) return;
            if (textBoxRegisterSN.Text == null || textBoxRegisterSN.Text == "") return;

            ValidationStatus validateCustomerSerialNumber = _kitting.ValidateCustomerSerialNumber(textBoxRegisterSN.Text, containerName);
            if (!validateCustomerSerialNumber.IsSuccess)
            {
                ShowMessage(ErrorCodeMeaning.Translate(validateCustomerSerialNumber.ErrorCode));
                textBoxRegisterSN.Clear();
                return;
            }

            ValidationStatus validateCustomerSerialNumberAlreadyExists = _kitting.CheckIfCustomerSNAlreadyUsedInBOM(materialRegistrationData.BillOfMaterial, textBoxRegisterSN.Text);
            if (!validateCustomerSerialNumberAlreadyExists.IsSuccess)
            {
                ShowMessage(ErrorCodeMeaning.Translate(validateCustomerSerialNumberAlreadyExists.ErrorCode));
                textBoxRegisterSN.Clear();
                return;
            }

            var IsContainerExists = _opcenterCheckData.IsContainerExists(textBoxRegisterSN.Text);
            if (IsContainerExists)
            {
                ShowMessage($"The Material {textBoxRegisterSN.Text} already registered!");
                textBoxRegisterSN.Clear();
                return;
            }

            // Select next field
            textBoxRegisterBatchID.Select();
        }

        private void CheckBatchID()
        {
            // Check Initial Data is Ready or Not
            if (textBoxRegisterBatchID.Text == null || textBoxRegisterBatchID.Text == "") return;

            ValidationStatus validateBatchID = _kitting.ValidateBatchID(textBoxRegisterBatchID.Text);
            if (!validateBatchID.IsSuccess)
            {
                ShowMessage(ErrorCodeMeaning.Translate(validateBatchID.ErrorCode));
                textBoxRegisterBatchID.Clear();
                return;
            }

            // Select next field
            textBoxRegisterPN.Select();
        }
        private bool IsRequiredFieldNotEmpty()
        {
            if (textBoxRegisterContainer.Text == "" || textBoxRegisterContainer.Text == null) return false;
            if (textBoxRegisterPN.Text == "" || textBoxRegisterPN.Text == null) return false;
            if (textBoxRegisterSN.Text == null || textBoxRegisterSN.Text == "") return false;
            return true;
        }
        private void buttonMaterialRegister_Click(object sender, EventArgs e)
        {
            if (!IsRequiredFieldNotEmpty()) return;

            // Clear the Initial materials
            listViewMaterial.Items.Clear();

            var newBOMs = materialRegistrationData.BillOfMaterial;
            for (int i = 0; i < newBOMs.Length; i++)
            {
                if (newBOMs[i].Product == textBoxRegisterPN.Text)
                {
                    newBOMs[i].isRegistered = true;
                    newBOMs[i].CustomerSerialNumber = textBoxRegisterSN.Text;
                    newBOMs[i].BatchID = textBoxRegisterBatchID.Text;
                }
            }
            GenerateListView(ref newBOMs, listViewMaterial);
            // reassign the new BOM
            materialRegistrationData.BillOfMaterial = newBOMs;

            //Reset Field
            textBoxRegisterPN.Clear();
            textBoxRegisterSN.Clear();
            textBoxRegisterBatchID.Clear();
        }

        private void textBoxRegisterContainer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckContainerRegistration();
            }
        }

        private void textBoxRegisterPN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckPartNumberRegistration();
            }
        }

        private void textBoxRegisterSN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckRegisterSN();
            }
        }

        private void textBoxRegisterBatchID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckBatchID();
            }
        }

        private void textBoxRegisterContainer_Leave(object sender, EventArgs e)
        {
            CheckContainerRegistration();
        }

        private void textBoxRegisterPN_Leave(object sender, EventArgs e)
        {
            CheckPartNumberRegistration();
        }

        private void textBoxRegisterSN_Leave(object sender, EventArgs e)
        {
            CheckRegisterSN();
        }

        private void textBoxRegisterBatchID_Leave(object sender, EventArgs e)
        {
            CheckBatchID();
        }

        private void buttonRegisterSubmit_Click(object sender, EventArgs e)
        {
            if (materialRegistrationData == null) return;
            if (containerName == null || containerName == "") return;

            var statusOfBOM = _kitting.CheckIfBOMAllRegistered(materialRegistrationData.BillOfMaterial);
            if (!statusOfBOM.IsSuccess)
            {
                ShowMessage(ErrorCodeMeaning.Translate(statusOfBOM.ErrorCode));
                return;
            }

            _opcenterSaveData.RegisterAllBillOfMaterial(materialRegistrationData.BillOfMaterial, containerName);

            ResetField();
        }

        private void ResetField()
        {
            textBoxRegisterContainer.Clear();
            textBoxRegisterBatchID.Clear();
            textBoxRegisterERPBOM.Clear();
            textBoxRegisterPN.Clear();
            listViewMaterial.Items.Clear();
            textBoxRegisterProduct.Clear();
            textBoxRegisterSN.Clear();

            materialRegistrationData = null;
            containerName = null;
        }
    }
}
