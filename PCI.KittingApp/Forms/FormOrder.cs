using PCI.KittingApp.Components;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCI.KittingApp.Forms
{
    public partial class FormOrder : Form
    {
        private OpcenterCheckData _opcenterCheckData;
        private OpcenterSaveData _opcenterSaveData;
        public FormOrder(OpcenterCheckData opcenterCheckData, OpcenterSaveData opcenterSaveData)
        {
            InitializeComponent();
            _opcenterCheckData = opcenterCheckData;
            _opcenterSaveData = opcenterSaveData;
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
            if (!_opcenterCheckData.IsProductExists(textBoxMfgProduct.Text)) return;
            if (!_opcenterCheckData.IsUOMExists(textBoxMfgUOM.Text)) return;
            if (!_opcenterCheckData.IsQtyDouble(textBoxMfgQty.Text)) return;
            bool result = _opcenterSaveData.SaveMfgOrder(textBoxMfgName.Text, textBoxMfgProduct.Text, textBoxMfgQty.Text, textBoxMfgUOM.Text);
            if (result) ResetField();
        }

        private void textBoxMfgName_Leave(object sender, EventArgs e)
        {
            // Check initial data
            if (textBoxMfgName.Text == null || textBoxMfgName.Text == "") return;

            if (!_opcenterCheckData.IsMfgOrderNotExists(textBoxMfgName.Text))
            {
                textBoxMfgName.Clear();
                return;
            }
        }

        private void textBoxMfgProduct_Leave(object sender, EventArgs e)
        {
            // Check initial data
            if (textBoxMfgProduct.Text == null || textBoxMfgProduct.Text == "") return;

            if (!_opcenterCheckData.IsProductExists(textBoxMfgProduct.Text))
            {
                textBoxMfgProduct.Clear();
                return;
            }
        }

        private void textBoxMfgQty_Leave(object sender, EventArgs e)
        {
            // Check initial data
            if (textBoxMfgQty.Text == null || textBoxMfgQty.Text == "") return;

            if (!_opcenterCheckData.IsQtyDouble(textBoxMfgQty.Text))
            {
                textBoxMfgQty.Clear();
                return;
            }
        }

        private void textBoxMfgUOM_Leave(object sender, EventArgs e)
        {
            // Check initial data
            if (textBoxMfgUOM.Text == null || textBoxMfgUOM.Text == "") return;

            if (!_opcenterCheckData.IsUOMExists(textBoxMfgUOM.Text))
            {
                textBoxMfgUOM.Clear();
                return;
            }
        }
    }
}
