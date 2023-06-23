using Camstar.WCF.ObjectStack;
using PCI.KittingApp.Components;
using PCI.KittingApp.Entity;
using PCI.KittingApp.Entity.TransactionType;
using PCI.KittingApp.Repository.Opcenter;
using PCI.KittingApp.UseCase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace PCI.KittingApp.Forms
{
    public partial class FormUnitRegistration : Form
    {
        //Fields
        private ProductDefaultStart _productDefaultData = null;
        private MfgOrderChanges _mfgOrderChanges = null;

        private OpcenterCheckData _opcenterCheckData;
        private OpcenterSaveData _opcenterSaveData;
        private Kitting _kitting;
        public FormUnitRegistration(OpcenterCheckData opcenterCheckData, Kitting kitting, OpcenterSaveData opcenterSaveData)
        {
            InitializeComponent();

            _opcenterCheckData = opcenterCheckData;
            _kitting = kitting;
            _opcenterSaveData = opcenterSaveData;
        }

        private void ResetField()
        {
            textBoxUnitContainer.Clear();
            _productDefaultData = null;
            EmptyInformationOfMfgOrder();
            textBoxUnitMfg.Select();
        }

        private bool IsRequiredFieldNotEmpty()
        {
            if (textBoxUnitMfg.Text == null || textBoxUnitMfg.Text == "") return false;
            if (textBoxUnitContainer.Text == null || textBoxUnitContainer.Text == "") return false;
            return true;
        }

        private void buttonUnitSubmit_Click(object sender, EventArgs e)
        {
            if (!IsRequiredFieldNotEmpty()) return;
            RegisterUnitContainer();
        }

        private void RegisterUnitContainer()
        {
            var data = new StartUnit() { ContainerName = textBoxUnitContainer.Text, MfgOrderName = textBoxUnitMfg.Text, ProductDefaultStart = _productDefaultData };
            string TxnId = Guid.NewGuid().ToString();
            if (_productDefaultData != null)
            {
                _opcenterSaveData.StartContainerMainUnit(data, TxnId);
                textBoxUnitContainer.Clear();
                _mfgOrderChanges = _opcenterCheckData.GetMfgOrderInformation(textBoxUnitMfg.Text);
                AssignedFieldReadOnly();
                textBoxUnitContainer.Select();
            }
        }

        private bool ValidateTheIDNCheckIfNotDuplicate(string ContainerName)
        {
            ValidationStatus isFGValid = _kitting.ValidateFGSerialNumberCheckIfNotDuplicate(ContainerName, _opcenterCheckData.IsContainerExists);
            if (!isFGValid.IsSuccess)
            {
                ZIAlertBox.Warning("Validation Message", $"The Container {ContainerName} {ErrorCodeMeaning.Translate(isFGValid.ErrorCode)}");
                textBoxUnitContainer.Clear();
                return false;
            }
            return true;
        }
        private bool ValidateTheCustomerSN()
        {
            ValidationStatus status = _kitting.ValidateCustomerSerialNumber(textBoxUnitContainer.Text);
            if (!status.IsSuccess)
            {
                ZIAlertBox.Warning("Validation Message", ErrorCodeMeaning.Translate(status.ErrorCode));
                textBoxUnitContainer.Clear();
                return false;
            }
            return true;
        }
        private void ValidateTheContainer()
        {
            // Check Initial Data is Ready or Not
            if (textBoxUnitContainer.Text == "" || textBoxUnitContainer.Text == null) return;

            var dataParse = textBoxUnitContainer.Text.Split('_');
            if (dataParse.Length == 1) // If only IDN
            {
                if (!ValidateTheIDNCheckIfNotDuplicate(textBoxUnitContainer.Text)) return;

                // Select next field
                buttonUnitSubmit.Select();
            } else if (dataParse.Length == 3) // If Customer SN
            {
                if (!ValidateTheIDNCheckIfNotDuplicate(dataParse[2])) return;
                if (!ValidateTheCustomerSN()) return;
                
                textBoxUnitContainer.Text = dataParse[2];

                // Select next field
                buttonUnitSubmit.Select();
            } else
            {
                textBoxUnitContainer.Text = "";
            }
        }
        private void textBoxUnitMfg_Leave(object sender, EventArgs e)
        {
            CheckMfgField();
        }

        private void CheckMfgField()
        {
            // Check Initial Data
            if (textBoxUnitMfg.Text == null || textBoxUnitMfg.Text == "") return;

            if (!_opcenterCheckData.IsMfgOrderExists(textBoxUnitMfg.Text))
            {
                EmptyInformationOfMfgOrder();
                return;
            }
            _mfgOrderChanges = _opcenterCheckData.GetMfgOrderInformation(textBoxUnitMfg.Text);
            _productDefaultData = _opcenterCheckData.ProductDefaultDataFromMfgOrder(_mfgOrderChanges);

            if (_productDefaultData == null)
            {
                EmptyInformationOfMfgOrder();
                return;
            }

            AssignedFieldReadOnly();

            // Select next field
            textBoxUnitContainer.Select();
        }

        private void EmptyInformationOfMfgOrder()
        {
            textBoxUnitMfg.Clear();
            dataGridUnitListContainer.Rows.Clear();
            _mfgOrderChanges= null;
            textBoxUnitBalance.Clear();
            textBoxUnitQty.Clear();
            textBoxUnitTotalQty.Clear();
            _productDefaultData = null;
        }

        private void AssignedFieldReadOnly()
        {
            if (_mfgOrderChanges == null) return;
            
            // Assign Qty
            if (_mfgOrderChanges.Qty != null) textBoxUnitQty.Text = _mfgOrderChanges.Qty.ToString();
            else textBoxUnitQty.Text = "0";

            // Assign TotalQty and Balance
            if (_mfgOrderChanges.Containers != null)
            {
                var balance = _mfgOrderChanges.Qty.Value - _mfgOrderChanges.Containers.Length;
                textBoxUnitBalance.Text = balance.ToString();
                textBoxUnitTotalQty.Text = _mfgOrderChanges.Containers.Length.ToString();
            }
            else
            {
                textBoxUnitBalance.Text = "0";
                textBoxUnitTotalQty.Text = "0";
            }

            // Assign list of containers
            dataGridUnitListContainer.Rows.Clear();
            if (_mfgOrderChanges.Containers == null) return;
            if (_mfgOrderChanges.Containers.Length> 0)
            {
                int i = 0;
                foreach (var item in _mfgOrderChanges.Containers)
                {
                    i++;
                    dataGridUnitListContainer.Rows.Add(i, item.Value);
                }
            }
        }

        private void textBoxUnitContainer_Leave(object sender, EventArgs e)
        {
            CheckContainerField();   
        }

        private void CheckContainerField()
        {
            ValidateTheContainer();
        }

        private void textBoxUnitContainer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckContainerField();
            }
        }

        private void textBoxUnitMfg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckMfgField();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetField();
        }
    }
}