using Camstar.WCF.ObjectStack;
using Camstar.WCF.Services;
using PCI.KittingApp.Components;
using PCI.KittingApp.Entity;
using PCI.KittingApp.UseCase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        public FormMaterialRegistration(Kitting kitting, OpcenterCheckData opcenterCheckData)
        {
            InitializeComponent();
            _kitting = kitting;
            _opcenterCheckData = opcenterCheckData;
        }

        private void textBoxRegisterContainer_KeyDown(object sender, KeyEventArgs e)
        {
            // Clear the Initial materials
            listViewMaterial.Items.Clear();

            if (e.KeyCode == Keys.Enter)
            {
                // Check Initial Data is Ready or Not
                if (textBoxRegisterContainer.Text == "" || textBoxRegisterContainer.Text == null) return;

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

                var newBOMs = materialRegistrationData.BillOfMaterial;
                GenerateListView(ref newBOMs, listViewMaterial);
                // reassign the new BOM
                materialRegistrationData.BillOfMaterial = newBOMs;
            }
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

        private void textBoxRegisterPN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
            }
        }

        private void textBoxRegisterSN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
                var IsContainerExists = _opcenterCheckData.IsContainerExists(textBoxRegisterSN.Text);
                if (IsContainerExists)
                {
                    ShowMessage($"The Material {textBoxRegisterSN.Text} already registered!");
                    textBoxRegisterSN.Clear();
                    return;
                }
            }
        }

        private void textBoxRegisterBatchID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Check Initial Data is Ready or Not
                if (textBoxRegisterBatchID.Text == null || textBoxRegisterBatchID.Text == "") return;

                ValidationStatus validateBatchID = _kitting.ValidateBatchID(textBoxRegisterBatchID.Text);
                if (!validateBatchID.IsSuccess)
                {
                    ShowMessage(ErrorCodeMeaning.Translate(validateBatchID.ErrorCode));
                    textBoxRegisterSN.Clear();
                    return;
                }
            }
        }
    }
}
