using PCI.KittingApp.Components;
using PCI.KittingApp.Entity;
using PCI.KittingApp.Entity.TransactionType;
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
    public partial class FormTransactionFailed : Form
    {
        private List<TransactionFailed> transactionFaileds = new List<TransactionFailed>();
        private UseCase.TransactionFailed _transactionFailedUsecase;
        public FormTransactionFailed(UseCase.TransactionFailed transactionFailedUsecase)
        {
            _transactionFailedUsecase = transactionFailedUsecase;
            InitializeComponent();

            LoadTransactionFailed();
        }

        private void LoadTransactionFailed()
        {
            // Clear The Datagrid
            dataGridTransactionFail.Rows.Clear();

            transactionFaileds = _transactionFailedUsecase.GetAll();

            foreach (var item in transactionFaileds)
            {
                dataGridTransactionFail.Rows.Add(item.Id, TransactionType.Translate(item.TypeTransaction), item.DataTransaction, item.DateTransaction);
            }
        }

        private void dataGridTransactionFail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridTransactionFail.Rows.Count == 0) return;
            if (dataGridTransactionFail.Columns[e.ColumnIndex].Name == "Retry")
            {
                var stringId = (string)dataGridTransactionFail.Rows[e.RowIndex].Cells["Id"].FormattedValue;
                if (stringId == "" || stringId == null) return;

                var dataTransaction = transactionFaileds.Find(x => x.Id == stringId);
                if (dataTransaction == null) return;
                _transactionFailedUsecase.RetryTheTransaction(dataTransaction);

                LoadTransactionFailed();
            }
        }
    }
}
