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
        private BackgroundWorker _backgroundWorker;
        public FormOrder(OpcenterCheckData opcenterCheckData, OpcenterSaveData opcenterSaveData)
        {
            InitializeComponent();
            _opcenterCheckData = opcenterCheckData;
            _opcenterSaveData = opcenterSaveData;

            RunGetUOM();
        }

        private void RunGetUOM()
        {
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.DoWork += (o, e) =>
            {
                e.Result = _opcenterCheckData.GetUOMList();

            };
            _backgroundWorker.RunWorkerCompleted += (o, e) =>
            {
                _listUOMs = (string[])e.Result;
                if (_listUOMs == null)
                    ZIAlertBox.Warning("Data Empty", "The list data of UOM cannot be retrieve, perhaps you lost connection or data empty!");
                AssignUOMList();
                return;
            };

            _backgroundWorker.RunWorkerAsync();
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

        private void buttonMfgSubmit_Click(object sender, EventArgs _)
        {
            if (!IsRequiredFieldNotEmpty()) return;
            
            // Run Background Worker
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.DoWork += (o, e) =>
            {
                var dataOrder = (CreateOrder)e.Argument;
                string TxnId = Guid.NewGuid().ToString();
                _opcenterSaveData.SaveMfgOrder(dataOrder, TxnId);
            };
            _backgroundWorker.RunWorkerCompleted += (o, e) =>
            {
                ResetField();
            };

            // Assign new Object
            var data = new CreateOrder() { MfgOrderName = textBoxMfgName.Text, ProductName = textBoxMfgProduct.Text, Qty = textBoxMfgQty.Text, UOM = comboBoxMfgUOM.SelectedText };
            _backgroundWorker.RunWorkerAsync(data);
        }

        private void textBoxMfgName_Leave(object sender, EventArgs e)
        {
            CheckMfgNameField();
        }

        private void CheckMfgNameField()
        {
            // Check initial data
            if (textBoxMfgName.Text == null || textBoxMfgName.Text == "") return;

            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.DoWork += (o, e) => {
                var mfgName = (string)e.Argument;
                e.Result = _opcenterCheckData.IsMfgOrderNotExists(mfgName);
            };
            _backgroundWorker.RunWorkerCompleted += (o, e) =>
            {
                if (!(bool)e.Result)
                {
                    textBoxMfgName.Clear();
                    textBoxMfgName.Select();
                    return;
                }

                // Select next field
                textBoxMfgProduct.Select();
                return;
            };
            _backgroundWorker.RunWorkerAsync(textBoxMfgName.Text);
        }

        private void textBoxMfgProduct_Leave(object sender, EventArgs e)
        {
            CheckProductField();
        }

        private void CheckProductField()
        {
            // Check initial data
            if (textBoxMfgProduct.Text == null || textBoxMfgProduct.Text == "") return;

            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.DoWork += (o, e) => {
                var productName = (string)e.Argument;
                e.Result = _opcenterCheckData.IsProductExists(productName);
            };
            _backgroundWorker.RunWorkerCompleted += (o, e) =>
            {
                if (!(bool)e.Result)
                {
                    textBoxMfgProduct.Clear();
                    textBoxMfgProduct.Select();
                    return;
                }

                // Select next field
                textBoxMfgQty.Select();
                return;
            };
            _backgroundWorker.RunWorkerAsync(textBoxMfgProduct.Text);
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
