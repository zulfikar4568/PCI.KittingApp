using PCI.KittingApp.Driver.SQLite;
using PCI.KittingApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Repository.SQLite
{
    public class TransactionFailed
    {
        private TransactionFailed<Entity.TransactionFailed> _transactionFailedDriver;
        public TransactionFailed(TransactionFailed<Entity.TransactionFailed> transactionFailedDriver)
        {
            _transactionFailedDriver = transactionFailedDriver;
        }

        public List<Entity.TransactionFailed> GetAll()
        {
            return _transactionFailedDriver.ReadAll("select * from TransactionFailed");
        }

        public void Insert(Entity.TransactionFailed entity)
        {
            _transactionFailedDriver.Write(entity, "insert into TransactionFailed (TypeTransaction, DataTransaction, DateTransaction) values (@TypeTransaction, @DataTransaction, @DateTransaction)");
        }

        public void Delete(string Id)
        {
            _transactionFailedDriver.Write($"delete from TransactionFailed WHERE Id = {Id}");
        }
    }
}
