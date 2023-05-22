using Camstar.WCF.ObjectStack;
using PCI.KittingApp.Components;
using PCI.KittingApp.Entity;
using PCI.KittingApp.Repository.Opcenter;
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
    public partial class FormUnitRegistration : Form
    {
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
        }

        private void buttonUnitSubmit_Click(object sender, EventArgs e)
        {
            if (!_opcenterCheckData.IsMfgOrderExists(textBoxUnitMfg.Text)) return;
            if (!ValidateTheContainer()) return;
            RegisterUnitContainer();
        }

        private void RegisterUnitContainer()
        {
            if (_opcenterSaveData.StartContainerMainUnit(textBoxUnitContainer.Text, textBoxUnitMfg.Text))
                ZIMessageBox.Show("Success Start the Container", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                ZIMessageBox.Show("Failed Start the Container, please see on event viewer for the Message!", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ResetField();
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
            if (!_opcenterCheckData.IsMfgOrderExists(textBoxUnitMfg.Text))
            {
                textBoxUnitMfg.Clear();
                return;
            }
        }


        private void textBoxUnitContainer_Leave(object sender, EventArgs e)
        {
            ValidateTheContainer();
        }

    }
}