using Camstar.WCF.ObjectStack;
using PCI.KittingApp.Components;
using PCI.KittingApp.Config;
using PCI.KittingApp.Entity;
using PCI.KittingApp.Entity.Printer;
using PCI.KittingApp.Entity.TransactionType;
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
    public partial class FormReprintingLabel : Form
    {
        //Field
        private List<PrintingLabel> _unitPrintingLabel = new List<PrintingLabel>();
        private List<PrintingLabel> _materialPrintingLabel = new List<PrintingLabel>();
        private PrintingLabelUseCase _printingLabelUseCase; 
        private OpcenterCheckData _opcenterCheckData;
        private Kitting _kitting;
        public FormReprintingLabel(PrintingLabelUseCase printingLabelUseCase, OpcenterCheckData opcenterCheckData, Kitting kitting)
        {
            InitializeComponent();
            _printingLabelUseCase = printingLabelUseCase; 
            _opcenterCheckData = opcenterCheckData;
            _kitting = kitting;

            ResetField();
        }

        private void ResetField()
        {
            _unitPrintingLabel.Clear();
            _materialPrintingLabel.Clear();

            buttonReprintingUnitLabel.Enabled = false;
            buttonReprintingMaterialLabel.Enabled = false;
        }
        private bool ValidateTheIDNCheckIfExists(string ContainerName)
        {
            ValidationStatus isFGValid = _kitting.ValidateFGSerialNumberCheckIfExists(ContainerName, _opcenterCheckData.IsContainerExists);
            if (!isFGValid.IsSuccess)
            {
                ZIAlertBox.Warning("Validation Message", $"The Container {ContainerName} {ErrorCodeMeaning.Translate(isFGValid.ErrorCode)}");
                textBoxPrintingContainer.Clear();
                return false;
            }
            return true;
        }
        private bool ValidateTheCustomerSN()
        {
            ValidationStatus status = _kitting.ValidateCustomerSerialNumber(textBoxPrintingContainer.Text);
            if (!status.IsSuccess)
            {
                ZIAlertBox.Warning("Validation Message", ErrorCodeMeaning.Translate(status.ErrorCode));
                textBoxPrintingContainer.Clear();
                return false;
            }
            return true;
        }

        private void ValidateTheContainer()
        {
            // Check Initial Data is Ready or Not
            if (textBoxPrintingContainer.Text == "" || textBoxPrintingContainer.Text == null) return;

            if (AppSettings.ConvertToCapital) 
                textBoxPrintingContainer.Text = textBoxPrintingContainer.Text.ToUpper();

            var dataParse = textBoxPrintingContainer.Text.Split('_');
            if (dataParse.Length == 1) // If only IDN
            {
                if (!ValidateTheIDNCheckIfExists(textBoxPrintingContainer.Text)) return;

                // Select next field
                textBoxPrintingContainer.Select();
            }
            else if (dataParse.Length == 3) // If Customer SN
            {
                if (!ValidateTheIDNCheckIfExists(dataParse[2])) return;
                if (!ValidateTheCustomerSN()) return;

                textBoxPrintingContainer.Text = dataParse[2];

                // Select next field
                textBoxPrintingContainer.Select();
            }
            else
            {
                textBoxPrintingContainer.Text = "";
            }
        }

        private void CheckListOfPrintingLabel()
        {
            ValidateTheContainer();
            dataGridUnitPrintingLabel.Rows.Clear();
            dataGridMaterialPrintingLabel.Rows.Clear();

            _unitPrintingLabel = _printingLabelUseCase.GetUnitPrintingLabel(textBoxPrintingContainer.Text);
            _materialPrintingLabel = _printingLabelUseCase.GetMaterialPrintingLabel(textBoxPrintingContainer.Text);

            if (_unitPrintingLabel == null || _materialPrintingLabel == null) return;

            if (_unitPrintingLabel.Count > 0)
            {
                buttonReprintingUnitLabel.Enabled = true;
                foreach (var item in _unitPrintingLabel)
                {
                    dataGridUnitPrintingLabel.Rows.Add(item.Id, item.DataTxn, item.DateTxn.ToString());
                }
            }

            if (_materialPrintingLabel.Count > 0)
            {
                buttonReprintingMaterialLabel.Enabled = true;
                foreach (var item in _materialPrintingLabel)
                {
                    dataGridMaterialPrintingLabel.Rows.Add(item.Id, item.DataTxn, item.DateTxn.ToString());
                }
            }
        }

        #region Event Handler
        private void buttonReprintingMaterialLabel_Click(object sender, EventArgs e)
        {
            foreach (var dataPrintingLabel in _materialPrintingLabel)
            {
                _printingLabelUseCase.StartPrintingLabel(dataPrintingLabel, false);
            }
        }

        private void buttonReprintingUnitLabel_Click(object sender, EventArgs e)
        {
            foreach (var dataPrintingLabel in _unitPrintingLabel)
            {
                _printingLabelUseCase.StartPrintingLabel(dataPrintingLabel, false);
            }
        }

        private void textBoxUnitContainer_Leave(object sender, EventArgs e)
        {
            CheckListOfPrintingLabel();
        }

        private void textBoxUnitContainer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckListOfPrintingLabel();
            }
        }
        #endregion

        private void dataGridUnitPrintingLabel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridUnitPrintingLabel.Columns[e.ColumnIndex].Name == "PrintUnit")
            {
                var stringId = (string)dataGridUnitPrintingLabel.Rows[e.RowIndex].Cells["IdUnit"].FormattedValue;
                if (stringId == "" || stringId == null) return;

                var dataPrintingLabel = _unitPrintingLabel.Find(x => x.Id == stringId);
                _printingLabelUseCase.StartPrintingLabel(dataPrintingLabel, false);
            }
        }

        private void dataGridMaterialPrintingLabel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridMaterialPrintingLabel.Columns[e.ColumnIndex].Name == "PrintMaterial")
            {
                var stringId = (string)dataGridMaterialPrintingLabel.Rows[e.RowIndex].Cells["IdMaterial"].FormattedValue;
                if (stringId == "" || stringId == null) return;

                var dataPrintingLabel = _materialPrintingLabel.Find(x => x.Id == stringId);
                _printingLabelUseCase.StartPrintingLabel(dataPrintingLabel, false);
            }
        }
    }
}
