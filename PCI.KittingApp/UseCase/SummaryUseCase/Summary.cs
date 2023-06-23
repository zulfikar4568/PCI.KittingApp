using Camstar.WCF.ObjectStack;
using PCI.KittingApp.Config;
using PCI.KittingApp.Entity.Summary;
using PCI.KittingApp.Entity.TransactionType;
using PCI.KittingApp.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PCI.KittingApp.UseCase
{
    public class SummaryUseCase
    {
        public List<SummaryMaterial> FindSummaryMaterial(ContainerAttributes dataAttributes)
        {
            List<SummaryMaterial> result = new List<SummaryMaterial>();
            if (dataAttributes.ContainerAttrDetails == null) return null;
            var findDataSummaryMaterial = dataAttributes.ContainerAttrDetails.Where((attr) => attr.Name.Value.Contains("SummaryMaterial_"));
            if (findDataSummaryMaterial == null) return null;
            if (findDataSummaryMaterial.ToList().Count == 0) return null;

            foreach (var summaryMaterialData in findDataSummaryMaterial)
            {
                if (summaryMaterialData == null) continue;
                if (summaryMaterialData.AttributeValue == null || summaryMaterialData.AttributeValue == "") continue;

                var extractTheSummaryMaterial = ExtractRecordSummary<SummaryMaterial>(summaryMaterialData.AttributeValue.Value);
                if (extractTheSummaryMaterial != null) result.Add(extractTheSummaryMaterial);
            }

            return result;
        }
        public T ExtractRecordSummary<T>(string Data)
        {
            try
            {
                if (string.IsNullOrEmpty(Data)) return default;
                return JsonSerializer.Deserialize<T>(Data);
            }
            catch (Exception ex)
            {
                ex.Source = AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source;
                EventLogUtil.LogErrorEvent(ex.Source, ex);
                return default;
            }
        }

        public SummaryUnit FindSummaryUnit(ContainerAttributes dataAttributes)
        {
            if (dataAttributes.ContainerAttrDetails== null) return null;
            var findDataSummaryUnit = dataAttributes.ContainerAttrDetails.First((attr) => attr.Name == "SummaryUnit");
            if (findDataSummaryUnit == null) return null;
            if (findDataSummaryUnit.AttributeValue == null || findDataSummaryUnit.AttributeValue == "") return null;

            return ExtractRecordSummary<SummaryUnit>(findDataSummaryUnit.AttributeValue.Value);
        }
        public void FilterTheDataFromAttributes(List<ContainerAttributes> containerAttributes, ref SummaryDataTable dataTable)
        {
            if (containerAttributes != null)
            {
                foreach (ContainerAttributes dataAttributes in containerAttributes)
                {
                    SummaryUnit summaryUnit = FindSummaryUnit(dataAttributes);
                    if (summaryUnit == null) continue;

                    List<SummaryMaterial> summaryMaterials = FindSummaryMaterial(dataAttributes);

                    // Assign Data Unit
                    var statusDone = false;
                    if (summaryMaterials != null)
                    {
                        if (summaryMaterials.ToArray().Length >= dataAttributes.MaterialRegistration.BillOfMaterial.Length) statusDone = true;
                    }
                    dataTable.DataSummaryUnit.Rows.Add(summaryUnit.VersanaSN, summaryUnit.KittingEmployee, statusDone ? "Completed" : "Not Completed");

                    if (summaryMaterials == null) continue;
                    if (summaryMaterials.Count == 0) continue;

                    // Assign Data Material
                    foreach (var summaryMaterial in summaryMaterials)
                    {
                        dataTable.DataSummaryMaterial.Rows.Add(summaryMaterial.VersanaSN, summaryMaterial.MaterialPN, summaryMaterial.CustomerSN, summaryMaterial.KittingEmployee);
                    }
                }
            }
        }
        public SummaryDataTable InstantiateDataTable()
        {
            var _summaryDataTable = new SummaryDataTable() { DataSummaryMaterial = new DataTable(), DataSummaryUnit = new DataTable() };

            //Parent table
            _summaryDataTable.DataSummaryUnit.Columns.Add("Versana S/N", typeof(string));
            _summaryDataTable.DataSummaryUnit.Columns.Add("Kitting Employee", typeof(string));
            _summaryDataTable.DataSummaryUnit.Columns.Add("Kitting Status", typeof(string));

            //Child table
            _summaryDataTable.DataSummaryMaterial.Columns.Add("Versana S/N", typeof(string));
            _summaryDataTable.DataSummaryMaterial.Columns.Add("P/N", typeof(string));
            _summaryDataTable.DataSummaryMaterial.Columns.Add("Customer S/N", typeof(string));
            _summaryDataTable.DataSummaryMaterial.Columns.Add("Kitting Employee", typeof(string));

            return _summaryDataTable;
        }
    }
}
