using Camstar.WCF.ObjectStack;
using PCI.KittingApp.Entity;
using PCI.KittingApp.Entity.DataGrid;
using PCI.KittingApp.Entity.Printer;
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
        public FormReprintingLabel(PrintingLabelUseCase printingLabelUseCase)
        {
            InitializeComponent();
            _printingLabelUseCase = printingLabelUseCase;

            ResetField();
        }

        private void ResetField()
        {
            _unitPrintingLabel.Clear();
            _materialPrintingLabel.Clear();

            buttonReprintingUnitLabel.Enabled = false;
            buttonReprintingMaterialLabel.Enabled = false;
        }

        private void CheckListOfPrintingLabel()
        {
            //  Clear Data Source
            reprintingLabelUnitBindingSource.Clear();
            reprintingLabelMaterialBindingSource.Clear();

            _unitPrintingLabel = _printingLabelUseCase.GetUnitPrintingLabel(textBoxPrintingContainer.Text);
            _materialPrintingLabel = _printingLabelUseCase.GetMaterialPrintingLabel(textBoxPrintingContainer.Text);

            if (_unitPrintingLabel == null || _materialPrintingLabel == null) return;

            if (_unitPrintingLabel.Count > 0)
            {
                buttonReprintingUnitLabel.Enabled = true;
                foreach (var item in _unitPrintingLabel)
                {
                    reprintingLabelUnitBindingSource.Add(new ReprintingLabelUnit() { UnitSN = item.DataTxn, DateStart = item.DateTxn.ToString()});
                }
                foreach (var item in _materialPrintingLabel)
                {
                    reprintingLabelMaterialBindingSource.Add(new ReprintingLabelMaterial() { MaterialSN = item.DataTxn, DateStart = item.DateTxn.ToString() });
                }
            }
        }

        #region Event Handler
        private void buttonReprintingMaterialLabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonReprintingUnitLabel_Click(object sender, EventArgs e)
        {

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
    }
}
