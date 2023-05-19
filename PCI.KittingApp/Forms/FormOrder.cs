using PCI.KittingApp.Components;
using PCI.KittingApp.Repository.Opcenter;
using PCI.KittingApp.Util;
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
    public partial class FormOrder : Form
    {
        private MaintenanceTransaction _maintenanceTransaction;
        public FormOrder(MaintenanceTransaction maintenanceTransaction)
        {
            InitializeComponent();
            _maintenanceTransaction = maintenanceTransaction;
        }

        private void ResetField()
        {
            textBoxMfgName.Clear();
            textBoxMfgProduct.Clear();
            textBoxMfgQty.Clear();
            textBoxMfgUOM.Clear();
        }

        private void buttonMfgSubmit_Click(object sender, EventArgs e)
        {
            if (!IsProductExists()) return;
            if (!IsUOMExists()) return;
            if (!IsQtyDouble()) return;
            bool result = _maintenanceTransaction.SaveMfgOrder(textBoxMfgName.Text, "", "", textBoxMfgProduct.Text, "", "", "", Convert.ToDouble(textBoxMfgQty.Text), null, "", textBoxMfgUOM.Text);
            if (result)
            {
                ZIMessageBox.Show($"Order {textBoxMfgName.Text} save succussfully!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetField();
            }
        }

        private bool IsProductExists()
        {

            if (!_maintenanceTransaction.ProductExists(textBoxMfgProduct.Text))
            {
                ZIMessageBox.Show($"Product {textBoxMfgProduct.Text} not found!", "Not Found Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool IsUOMExists()
        {
            if (!_maintenanceTransaction.UOMExists(textBoxMfgUOM.Text))
            {
                ZIMessageBox.Show($"UOM {textBoxMfgUOM.Text} not found!", "Not Found Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool IsQtyDouble()
        {
            if (!Formatting.CanCovertTo<Double>(textBoxMfgQty.Text))
            {
                ZIMessageBox.Show($"Qty {textBoxMfgUOM.Text} is not number!", "Type Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void textBoxMfgProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!IsProductExists()) return;
            }
        }

        private void textBoxMfgQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!IsQtyDouble()) return;
            }
        }

        private void textBoxMfgUOM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!IsUOMExists()) return;
            }
        }
    }
}
