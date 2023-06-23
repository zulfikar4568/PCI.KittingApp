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

            RunningHeavyFilterData(MfgOrderChanges.Containers);
        }
        private void RunningHeavyFilterData(Primitive<string>[] containers)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (o, e) =>
            {
                var containerParams = (Primitive<string>[])e.Argument;
                SummaryDataTable summaryDataTable = _summaryUseCase.InstantiateDataTable();
                _summaryUseCase.FilterTheDataFromAttributes(_opcenterCheckData.GetContainerAttrDetails(containerParams), ref summaryDataTable);
                e.Result = summaryDataTable;
            };
            worker.RunWorkerCompleted += (o, e) =>
            {
                var summaryDataTable = (SummaryDataTable)e.Result;

                InitializationDataGrid(summaryDataTable);
            };
            worker.RunWorkerAsync(containers);
        }
        private void InitializationDataGrid(SummaryDataTable summaryDataTable)
        {
            // Create new DataSet
            var dataSet = new DataSet();

            //Add two DataTables  in Dataset
            dataSet.Tables.Add(summaryDataTable.DataSummaryUnit);
            dataSet.Tables.Add(summaryDataTable.DataSummaryMaterial);

            if (dataSet.Tables[0].Rows.Count > 0 && dataSet.Tables[1].Rows.Count > 0)
            {
                DataRelation Datatablerelation = new DataRelation("List of Material", dataSet.Tables[0].Columns[0], dataSet.Tables[1].Columns[0], true);
                dataSet.Relations.Add(Datatablerelation);
            }

            dataGridListContainer.DataSource = dataSet.Tables[0];

            dataGridListContainer.DataBindings.Clear();
            dataGridListContainer.PreferredColumnWidth = (int)(dataGridListContainer.Width / 2.5);
        }
        private void EmptyInformationOfMfgOrder()
        {
            textBoxMfg.Clear();
            textBoxBalance.Clear();
            textBoxQty.Clear();
            textBoxTotalQty.Clear();
            InitializationDataGrid(_summaryUseCase.InstantiateDataTable());
        }

        #region Event Trigger
        private void FormSummary_Load(object sender, EventArgs e)
        {
            EmptyInformationOfMfgOrder();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            CheckMfgField();
        }
        #endregion
    }
}
