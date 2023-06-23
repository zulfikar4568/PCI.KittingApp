using PCI.KittingApp.Config;
using PCI.KittingApp.Entity.Summary;
using PCI.KittingApp.Util;
using System;
using System.Collections.Generic;
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
    }
}
