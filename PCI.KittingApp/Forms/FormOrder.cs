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

        private void textBoxMfgProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!!_opcenterCheckData.IsProductExists(textBoxMfgProduct.Text)) return;
            }
        }

        private void textBoxMfgQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!_opcenterCheckData.IsQtyDouble(textBoxMfgQty.Text)) return;
            }
        }

        private void textBoxMfgUOM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!_opcenterCheckData.IsUOMExists(textBoxMfgUOM.Text)) return;
            }
        }
    }
}
