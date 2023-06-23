using Camstar.WCF.ObjectStack;
using PCI.KittingApp.Config;
using PCI.KittingApp.Entity;
using PCI.KittingApp.Entity.Summary;
using PCI.KittingApp.UseCase;
using PCI.KittingApp.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace PCI.KittingApp.Forms
{
    public partial class FormSummary : Form
    {
        //Field
        private DataTable dataSummaryUnit = null;
        private DataTable dataSummaryMaterial = null;
        private DataSet dataSet = null;
        private List<ContainerAttributes> _containerAttributes = new List<ContainerAttributes>();

        private OpcenterCheckData _opcenterCheckData;
        private SummaryUseCase _summaryUseCase;
        public FormSummary(OpcenterCheckData opcenterCheckData, SummaryUseCase summaryUseCase)
        {
            InitializeComponent();
            _opcenterCheckData = opcenterCheckData;
            _summaryUseCase = summaryUseCase;
        }

        private void CheckMfgField()
        {
            // Check Initial Data
            if (textBoxMfg.Text == null || textBoxMfg.Text == "") return;

            InitialTable();

            if (!_opcenterCheckData.IsMfgOrderExists(textBoxMfg.Text))
            {
                EmptyInformationOfMfgOrder();
                return;
            }
            var mfgOrderChanges = _opcenterCheckData.GetMfgOrderInformation(textBoxMfg.Text);

            AssignedFieldReadOnly(mfgOrderChanges);

            textBoxQty.Select();
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

            _containerAttributes = _opcenterCheckData.GetContainerAttrDetails(MfgOrderChanges.Containers);
            if (_containerAttributes != null)
            {
                foreach (ContainerAttributes dataAttributes in _containerAttributes)
                {
                    SummaryUnit summaryUnit = _summaryUseCase.FindSummaryUnit(dataAttributes);
                    if (summaryUnit == null) continue;

                    List<SummaryMaterial> summaryMaterials = _summaryUseCase.FindSummaryMaterial(dataAttributes);

                    // Assign Data Unit
                    var statusDone = false;
                    if (summaryMaterials != null)
                    {
                        if (summaryMaterials.ToArray().Length >= dataAttributes.MaterialRegistration.BillOfMaterial.Length) statusDone = true;
                    }
                    dataSummaryUnit.Rows.Add(summaryUnit.VersanaSN, summaryUnit.KittingEmployee, statusDone ? "Completed" : "Not Completed");

                    if (summaryMaterials == null) continue;
                    if (summaryMaterials.Count == 0) continue;

                    // Assign Data Material
                    foreach (var summaryMaterial in summaryMaterials)
                    {
                        dataSummaryMaterial.Rows.Add(summaryMaterial.VersanaSN, summaryMaterial.MaterialPN, summaryMaterial.CustomerSN, summaryMaterial.KittingEmployee);
                    }
                }
            }

            //Add two DataTables  in Dataset 
            dataSet.Tables.Add(dataSummaryUnit);
            dataSet.Tables.Add(dataSummaryMaterial);

            if (dataSet.Tables[0].Rows.Count > 0 && dataSet.Tables[1].Rows.Count > 0)
            {
                DataRelation Datatablerelation = new DataRelation("List of Material", dataSet.Tables[0].Columns[0], dataSet.Tables[1].Columns[0], true);
                dataSet.Relations.Add(Datatablerelation);
            }
            
            dataGridListContainer.DataSource = dataSet.Tables[0];
        }

        private void InitialTable()
        {
            // Empty First
            dataSummaryMaterial = new DataTable();
            dataSummaryUnit = new DataTable();
            dataSet = new DataSet();
            dataGridListContainer.DataBindings.Clear();

            //Parent table
            dataSummaryUnit.Columns.Add("Versana S/N", typeof(string));
            dataSummaryUnit.Columns.Add("Kitting Employee", typeof(string));
            dataSummaryUnit.Columns.Add("Kitting Status", typeof(string));

            //Child table
            dataSummaryMaterial.Columns.Add("Versana S/N", typeof(string));
            dataSummaryMaterial.Columns.Add("P/N", typeof(string));
            dataSummaryMaterial.Columns.Add("Customer S/N", typeof(string));
            dataSummaryMaterial.Columns.Add("Kitting Employee", typeof(string));

            dataGridListContainer.PreferredColumnWidth = (int)(dataGridListContainer.Width / 2.5);
        }
        private void EmptyInformationOfMfgOrder()
        {
            textBoxMfg.Clear();
            textBoxBalance.Clear();
            textBoxQty.Clear();
            textBoxTotalQty.Clear();
        }

        #region Event Trigger
        private void FormSummary_Load(object sender, EventArgs e)
        {
            InitialTable();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            CheckMfgField();
        }
        #endregion
    }
}
