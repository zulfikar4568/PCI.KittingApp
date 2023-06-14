using Camstar.WCF.ObjectStack;
using PCI.KittingApp.Components;
using PCI.KittingApp.Entity.TransactionType;
using PCI.KittingApp.Repository.Opcenter;
using PCI.KittingApp.UseCase;
using PCI.KittingApp.Util;
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
    public partial class FormOrder : Form
    {
        //Fields
        private string[] _listUOMs = null;

        private OpcenterCheckData _opcenterCheckData;
        private OpcenterSaveData _opcenterSaveData;
        public FormOrder(OpcenterCheckData opcenterCheckData, OpcenterSaveData opcenterSaveData)
        {
            InitializeComponent();
            _opcenterCheckData = opcenterCheckData;
            _opcenterSaveData = opcenterSaveData;

            _listUOMs = _opcenterCheckData.GetUOMList();
            if (_listUOMs == null) 
                ZIMessageBox.Show("The list data of UOM cannot be retrieve, perhaps you lost connection or data empty!", "Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            AssignUOMList();
        }
        private void AssignUOMList()
        {
            if (_listUOMs == null) return;
            comboBoxMfgUOM.Items.Clear();
            foreach (var item in _listUOMs)
            {
                comboBoxMfgUOM.Items.Add(item);
                if (item.ToUpper() == "UNIT")
                {
                    comboBoxMfgUOM.SelectedIndex = comboBoxMfgUOM.Items.IndexOf(item);
                }
            }

            textBoxMfgName.Select();
        }
        private void ResetField()
        {
            textBoxMfgName.Clear();
            textBoxMfgProduct.Clear();
            textBoxMfgQty.Clear();
            AssignUOMList();
        }
        private bool IsRequiredFieldNotEmpty()
        {
            if (textBoxMfgName.Text == null || textBoxMfgName.Text == "") return false;
            if (textBoxMfgProduct.Text == null || textBoxMfgProduct.Text == "") return false;
            if (textBoxMfgQty.Text == null || textBoxMfgQty.Text == "") return false;
            if (comboBoxMfgUOM.SelectedIndex== -1) return false;
            return true;
        }

        private void buttonMfgSubmit_Click(object sender, EventArgs e)
        {
            if (!IsRequiredFieldNotEmpty()) return;
            var data = new CreateOrder() { MfgOrderName = textBoxMfgName.Text , ProductName = textBoxMfgProduct.Text, Qty = textBoxMfgQty.Text , UOM = comboBoxMfgUOM.SelectedText };
            string TxnId = Guid.NewGuid().ToString();
            _opcenterSaveData.SaveMfgOrder(data, TxnId);
            ResetField();
        }

        private void textBoxMfgName_Leave(object sender, EventArgs e)
        {
            CheckMfgNameField();
        }

        private void CheckMfgNameField()
        {
            // Check initial data
            if (textBoxMfgName.Text == null || textBoxMfgName.Text == "") return;

            if (!_opcenterCheckData.IsMfgOrderNotExists(textBoxMfgName.Text))
            {
                textBoxMfgName.Clear();
                return;
            }

            // Select next field
            textBoxMfgProduct.Select();
        }

        private void textBoxMfgProduct_Leave(object sender, EventArgs e)
        {
            CheckProductField();
        }

        private void CheckProductField()
        {
            // Check initial data
            if (textBoxMfgProduct.Text == null || textBoxMfgProduct.Text == "") return;

            if (!_opcenterCheckData.IsProductExists(textBoxMfgProduct.Text))
            {
                textBoxMfgProduct.Clear();
                return;
            }

            // Select next field
            textBoxMfgQty.Select();
        }

        private void textBoxMfgQty_Leave(object sender, EventArgs e)
        {
            CheckQtyField();
        }

        private void CheckQtyField()
        {
            // Check initial data
            if (textBoxMfgQty.Text == null || textBoxMfgQty.Text == "") return;

            if (!_opcenterCheckData.IsQtyDouble(textBoxMfgQty.Text))
            {
                textBoxMfgQty.Clear();
                return;
            }

            // Select next field
            buttonMfgSubmit.Select();
        }
        private void comboBoxMfgUOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckUOMField();
        }

        private void CheckUOMField()
        {
            // Check initial data
            if (comboBoxMfgUOM.SelectedIndex == -1) return;

            // Select next field
            buttonMfgSubmit.Select();
        }

        private void textBoxMfgName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckMfgNameField();
            }
        }

        private void textBoxMfgProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckProductField();
            }
        }

        private void textBoxMfgQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckQtyField();
            }
        }
    }
}
