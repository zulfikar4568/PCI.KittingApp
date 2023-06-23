using Camstar.WCF.ObjectStack;
using PCI.KittingApp.Entity;
using PCI.KittingApp.Entity.Summary;
using PCI.KittingApp.UseCase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace PCI.KittingApp.Forms
{
    public partial class FormSummary : Form
    {
        //Field
        private DataTable dataSummaryUnit = new DataTable();
        private DataTable dataSummaryMaterial = new DataTable();
        private DataSet dataSet = new DataSet();
        private List<ContainerAttributes> _containerAttributes = new List<ContainerAttributes>();

        private OpcenterCheckData _opcenterCheckData;
        public FormSummary(OpcenterCheckData opcenterCheckData)
        {
            InitializeComponent();
            _opcenterCheckData = opcenterCheckData;
        }

        private void CheckMfgField()
        {
            // Check Initial Data
            if (textBoxMfg.Text == null || textBoxMfg.Text == "") return;

            if (!_opcenterCheckData.IsMfgOrderExists(textBoxMfg.Text))
            {
                EmptyInformationOfMfgOrder();
                return;
            }
            var mfgOrderChanges = _opcenterCheckData.GetMfgOrderInformation(textBoxMfg.Text);

            AssignedFieldReadOnly(mfgOrderChanges);

            // Select next field
            textBoxMfg.Select();
        }
        private void AssignedFieldReadOnly(MfgOrderChanges MfgOrderChanges)
        {
            if (MfgOrderChanges == null) return;

            // Assign Qty
            if (MfgOrderChanges.Qty != null) textBoxQty.Text = MfgOrderChanges.Qty.ToString();
            else textBoxQty.Text = "0";

            // Assign TotalQty and Balance
            if (MfgOrderChanges.Containers != null)
            {
                var balance = MfgOrderChanges.Qty.Value - MfgOrderChanges.Containers.Length;
                textBoxBalance.Text = balance.ToString();
                textBoxTotalQty.Text = MfgOrderChanges.Containers.Length.ToString();
            }
            else
            {
                textBoxBalance.Text = "0";
                textBoxTotalQty.Text = "0";
            }

            // Assign list of containers
            if (MfgOrderChanges.Containers == null) return;
            _containerAttributes = _opcenterCheckData.GetContainerAttrDetails(MfgOrderChanges.Containers);
        }
        private void EmptyInformationOfMfgOrder()
        {
            textBoxMfg.Clear();
            dataGridListContainer.DataBindings.Clear();
            textBoxBalance.Clear();
            textBoxQty.Clear();
            textBoxTotalQty.Clear();
        }

        #region Event Trigger
        private void textBoxMfg_Leave(object sender, EventArgs e)
        {
            CheckMfgField();
        }

        private void textBoxMfg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckMfgField();
            }
        }
        #endregion

        private void FormSummary_Load(object sender, EventArgs e)
        {
            //Parent table
            dataSummaryUnit.Columns.Add("Versana S/N", typeof(string));
            dataSummaryUnit.Columns.Add("Kitting Employee", typeof(string));
            dataSummaryUnit.Columns.Add("Kitting Status", typeof(string));

            //Child table
            dataSummaryMaterial.Columns.Add("Versana S/N", typeof(int));
            dataSummaryMaterial.Columns.Add("P/N", typeof(int));
            dataSummaryMaterial.Columns.Add("Customer S/N", typeof(string));
            dataSummaryMaterial.Columns.Add("Kitting Employee", typeof(int));


            /* 
            dataSummaryMaterial.Rows.Add(222, "01", "Physics", 80);
            dataSummaryMaterial.Rows.Add(222, "02", "English", 95);
            dataSummaryMaterial.Rows.Add(222, "03", "Commerce", 95);
            dataSummaryMaterial.Rows.Add(222, "01", "BankPO", 99);
            
            dataSummaryUnit.Rows.Add(111, "Devesh", "03021013014", "Done");
            dataSummaryUnit.Rows.Add(222, "ROLI", "0302101444", "Done");
            dataSummaryUnit.Rows.Add(333, "ROLI Ji", "030212222", "Done");
            dataSummaryUnit.Rows.Add(444, "NIKHIL", "KANPUR", "Done");

            
            dataSummaryMaterial.Rows.Add(111, "01", "Physics", 99);
            dataSummaryMaterial.Rows.Add(111, "02", "Maths", 77);
            dataSummaryMaterial.Rows.Add(111, "03", "C#", 100);
            dataSummaryMaterial.Rows.Add(111, "01", "Physics", 99);*/

            //Add two DataTables  in Dataset 
            dataSet.Tables.Add(dataSummaryUnit);
            dataSet.Tables.Add(dataSummaryMaterial);

            if (dataSet.Tables[0].Rows.Count > 0 && dataSet.Tables[1].Rows.Count > 0)
            {
                DataRelation Datatablerelation = new DataRelation("List of Material", dataSet.Tables[0].Columns[0], dataSet.Tables[1].Columns[0], true);
                dataSet.Relations.Add(Datatablerelation);
            }

            dataGridListContainer.DataSource = dataSet.Tables[0];
            dataGridListContainer.PreferredColumnWidth = (int)(dataGridListContainer.Width / 2.5);
        }
    }
}
