using Camstar.WCF.ObjectStack;
using PCI.KittingApp.Components;
using PCI.KittingApp.Entity;
using PCI.KittingApp.Entity.TransactionFailedType;
using PCI.KittingApp.Repository.Opcenter;
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
using System.Windows.Markup;

namespace PCI.KittingApp.Forms
{
    public partial class FormUnitRegistration : Form
    {
        //Fields
        private ProductDefaultStart _productDefaultData = null;

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
            textBoxUnitMfg.Clear();
            _productDefaultData = null;
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
            if (_productDefaultData != null)
            {
                _opcenterSaveData.StartContainerMainUnit(data);
                ResetField();
            }
        }

        private bool ValidateTheContainer()
        {
            bool result = true;
            ValidationStatus isFGValid = _kitting.ValidateFGSerialNumber(textBoxUnitContainer.Text, _opcenterCheckData.IsContainerExists);
            if (!isFGValid.IsSuccess)
            {
                ZIMessageBox.Show(ErrorCodeMeaning.Translate(isFGValid.ErrorCode), "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUnitContainer.Clear();
                result = false;
            }
            return result;
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
                textBoxUnitMfg.Clear();
                return;
            }

            _productDefaultData = _opcenterCheckData.ProductDefaultDataFromMfgOrder(textBoxUnitMfg.Text);

            // Select next field
            buttonUnitSubmit.Select();
        }


        private void textBoxUnitContainer_Leave(object sender, EventArgs e)
        {
            CheckContainerField();   
        }

        private void CheckContainerField()
        {
            // Check Initial Data
            if (textBoxUnitContainer.Text == null || textBoxUnitContainer.Text == "") return;

            ValidateTheContainer();

            // Select next field
            textBoxUnitMfg.Select();
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
    }
}