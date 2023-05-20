using Camstar.WCF.ObjectStack;
using Camstar.WCF.Services;
using PCI.KittingApp.Config;
using PCI.KittingApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Repository.Opcenter
{
    public class MaintenanceTransaction
    {
        private readonly Driver.Opcenter.MaintenanceTransaction _maintenanceTxn;
        private readonly Driver.Opcenter.Helper _helper;
        public MaintenanceTransaction(Driver.Opcenter.MaintenanceTransaction maintenanceTxn, Driver.Opcenter.Helper helper)
        {
            _maintenanceTxn = maintenanceTxn;
            _helper = helper;
        }

        public bool ContainerLevelExists(string ContainerLevelName)
        {
            ContainerLevelMaintService oServiceMfgOrder = new ContainerLevelMaintService(AppSettings.ExCoreUserProfile);
            return _helper.ObjectExists(oServiceMfgOrder, new ContainerLevelMaint(), ContainerLevelName);
        }
        public bool MfgOrderExists(string MfgOrderName)
        {
            MfgOrderMaintService oServiceMfgOrder= new MfgOrderMaintService(AppSettings.ExCoreUserProfile);
            return _helper.ObjectExists(oServiceMfgOrder, new MfgOrderMaint(), MfgOrderName);
        }
        public bool ProductTypeExists(string ProductTypeName)
        {
            ProductTypeMaintService oServiceProduct = new ProductTypeMaintService(AppSettings.ExCoreUserProfile);
            return _helper.ObjectExists(oServiceProduct, new ProductTypeMaint(), ProductTypeName);
        }
        public bool ProductExists(string ProductName, string ProductRevision = "")
        {
            ProductMaintService oServiceProduct = new ProductMaintService(AppSettings.ExCoreUserProfile);
            return _helper.ObjectExists(oServiceProduct, new ProductMaint(), ProductName, ProductRevision);
        }
        public bool UOMExists(string UOMName)
        {
            UOMMaintService oServiceUOM = new UOMMaintService(AppSettings.ExCoreUserProfile);
            return _helper.ObjectExists(oServiceUOM, new UOMMaint(), UOMName);
        }
        public bool SaveOrderType(string Name, string Description = "", bool IgnoreException = true)
        {
            OrderTypeChanges objectChanges = new OrderTypeChanges();
            objectChanges.Name = Name;
            objectChanges.Description = Description;
            return _maintenanceTxn.OrderTypeTxn(objectChanges, IgnoreException);
        }
        public bool SaveOrderStatus(string Name, dynamic isOrderStates, string Description = "", bool IgnoreException = true)
        {
            OrderStatusChanges objectChanges = new OrderStatusChanges();
            objectChanges.Name = Name;
            objectChanges.isOrderStates = isOrderStates;
            objectChanges.Description = Description;
            return _maintenanceTxn.OrderStatusTxn(objectChanges, IgnoreException);
        }
        public bool SaveMfgOrder(string Name, string Description = "", string Notes = "", string ProductName = "", string ProductRevision = "", string WorkflowName = "", string WorkflowRevision = "", double Qty = 0, List<MfgOrderMaterialListItmChanges> MaterialList = null, string ERPRoute = "", string UOM = "", string PlannedStartDate = "", string PlannedCompletedDate = "", string ReleaseDate = "", string OrderStatus = "", string OrderType = "", bool IgnoreException = true)
        {
            MfgOrderChanges objectChanges = new MfgOrderChanges();
            objectChanges.Name = new Primitive<string>() { Value = Name };
            if (ERPRoute != "") objectChanges.ERPRoute = new RevisionedObjectRef(ERPRoute);
            if (OrderStatus != "") objectChanges.OrderStatus = new NamedObjectRef(OrderStatus);
            if (UOM != "") objectChanges.UOM = new NamedObjectRef(UOM);
            if (ProductName != "" && ProductRevision != "" && _helper.ObjectExists(new ProductMaintService(AppSettings.ExCoreUserProfile), new ProductMaint(), ProductName, ProductRevision))
            {
                objectChanges.Product = new RevisionedObjectRef(ProductName, ProductRevision);
            }
            else if (ProductName != "" && _helper.ObjectExists(new ProductMaintService(AppSettings.ExCoreUserProfile), new ProductMaint(), ProductName, ""))
            {
                objectChanges.Product = new RevisionedObjectRef(ProductName);
            }

            if (WorkflowName != "" && WorkflowRevision != "" && _helper.ObjectExists(new WorkflowMaintService(AppSettings.ExCoreUserProfile), new WorkflowMaint(), WorkflowName, WorkflowRevision))
            {
                objectChanges.isWorkflow = new RevisionedObjectRef(WorkflowName, WorkflowRevision);
            }
            else if (WorkflowName != "" && _helper.ObjectExists(new WorkflowMaintService(AppSettings.ExCoreUserProfile), new WorkflowMaint(), WorkflowName, ""))
            {
                objectChanges.isWorkflow = new RevisionedObjectRef(WorkflowName);
            }
            if (Qty > 0) objectChanges.Qty = new Primitive<double>() { Value = Qty };
            if (Description != "") objectChanges.Description = new Primitive<string>() { Value = Description };
            if (Notes != "") objectChanges.Notes = new Primitive<string>() { Value = Notes };
            if (OrderType != "") objectChanges.OrderType = new NamedObjectRef(OrderType);
            if (MaterialList != null)
            {
                if (MaterialList.Count > 0)
                {
                    objectChanges.ReplaceDetails = true;
                    objectChanges.ReplaceDetailsSubentityListNames = "MaterialList";
                    var oMaterialList = objectChanges.MaterialList;
                    Array.Resize(ref oMaterialList, MaterialList.Count);
                    objectChanges.MaterialList = oMaterialList;
                    for (int index = 0; index < MaterialList.Count; index++)
                    {
                        objectChanges.MaterialList[index] = MaterialList[index];
                    }
                }
            }
            if (Formatting.IsDate(PlannedStartDate)) objectChanges.PlannedStartDate = new Primitive<DateTime>() { Value = Convert.ToDateTime(PlannedStartDate) };
            if (Formatting.IsDate(PlannedCompletedDate)) objectChanges.PlannedCompletionDate = new Primitive<DateTime>() { Value = Convert.ToDateTime(PlannedCompletedDate) };
            if (Formatting.IsDate(ReleaseDate)) objectChanges.ReleaseDate = new Primitive<DateTime>() { Value = Convert.ToDateTime(ReleaseDate) };
            return _maintenanceTxn.MfgOrderTxn(objectChanges, IgnoreException);
        }
        public bool SaveProduct(string ProductName, string Revision, string IsRevOfRcd = "", string Description = "", string Notes = "", string ProductType = "", string DocumentSet = "", string WorkflowName = "", string WorkflowRevision = "", string BOMName = "", string BOMRevision = "", string ProductFamily = "", string StartUOM = "", double StartQty = 0, bool IgnoreException = true)
        {
            ProductChanges objectChanges = new ProductChanges();
            objectChanges.Name = new Primitive<string>() { Value = ProductName };
            objectChanges.Revision = new Primitive<string>() { Value = Revision };
            if (StartUOM != "") objectChanges.StdStartUOM = new NamedObjectRef(StartUOM);
            if (StartQty > 0) objectChanges.StdStartQty = new Primitive<double>() { Value = StartQty };
            if (ProductFamily != "") objectChanges.ProductFamily = new NamedObjectRef(ProductFamily);
            if (IsRevOfRcd != "") objectChanges.IsRevOfRcd = new Primitive<bool>() { Value = Convert.ToBoolean(IsRevOfRcd) };
            if (Description != "") objectChanges.Description = new Primitive<string>() { Value = Description };
            if (Notes != "") objectChanges.Notes = new Primitive<string>() { Value = Notes };
            if (ProductType != "") objectChanges.ProductType = new NamedObjectRef(ProductType);
            if (DocumentSet != "") objectChanges.DocumentSet = new NamedObjectRef(DocumentSet);
            if (WorkflowName != "" && WorkflowRevision == "")
            {
                objectChanges.Workflow = new RevisionedObjectRef(WorkflowName);
            }
            else if (WorkflowName != "" && WorkflowRevision != "")
            {
                objectChanges.Workflow = new RevisionedObjectRef(WorkflowName, WorkflowRevision);
            }
            if (BOMName != "" && BOMRevision == "")
            {
                objectChanges.BOM = new RevisionedObjectRef(BOMName);
            }
            else if (BOMName != "" && BOMRevision != "")
            {
                objectChanges.BOM = new RevisionedObjectRef(BOMName, BOMRevision);
            }
            return _maintenanceTxn.ProductTxn(objectChanges, IgnoreException);
        }
        public bool SaveProductFamily(string Name, string Description = "", string WorkflowName = "", string WorkflowRevision = "", string DocumentSet = "", string ContainerNumberingRule = "", bool IgnoreException = true)
        {
            ProductFamilyChanges objectChanges = new ProductFamilyChanges();
            objectChanges.Name = new Primitive<string>() { Value = Name };
            if (Description != "") objectChanges.Description = new Primitive<string>() { Value = Description };
            if (WorkflowName != "" && WorkflowRevision != "")
            {
                objectChanges.Workflow = new RevisionedObjectRef(WorkflowName, WorkflowRevision);
            }
            else if (WorkflowName != "")
            {
                objectChanges.Workflow = new RevisionedObjectRef(WorkflowName);
            }
            if (DocumentSet != "") objectChanges.DocumentSet = new NamedObjectRef(DocumentSet);
            if (ContainerNumberingRule != "") objectChanges.ContainerNumberingRule = new NamedObjectRef(ContainerNumberingRule);
            return _maintenanceTxn.ProductFamilyTxn(objectChanges, IgnoreException);
        }
        public bool SaveProductType(string Name, string Description = "", bool IgnoreException = true)
        {
            ProductTypeChanges objectChanges = new ProductTypeChanges();
            objectChanges.Name = new Primitive<string>() { Value = Name };
            if (Description != "") objectChanges.Description = new Primitive<string>() { Value = Description };
            return _maintenanceTxn.ProductTypeTxn(objectChanges, IgnoreException);
        }
        public bool SaveUOM(string Name, string Description = "", bool IgnoreException = true)
        {
            UOMChanges objectChanges = new UOMChanges();
            objectChanges.Name = new Primitive<string>() { Value = Name };
            if (Description != "") objectChanges.Description = new Primitive<string>() { Value = Description };
            return _maintenanceTxn.UOMTxn(objectChanges, IgnoreException);
        }
        public ProductChanges GetProduct(string ProductName, string ProductRevision = "", bool IgnoreException = true)
        {
            RevisionedObjectRef objectToChange = new RevisionedObjectRef(ProductName);
            if (ProductName != "" && ProductRevision != "")
            {
                objectToChange = new RevisionedObjectRef(ProductName, ProductRevision);
            }
            ProductChanges_Info productInfo = new ProductChanges_Info();

            productInfo.ProductType = new Info(true);
            productInfo.ProductFamily = new Info(true);
            productInfo.Workflow = new Info(true);
            productInfo.Name = new Info(true);
            productInfo.Description = new Info(true);
            productInfo.ERPBOM = new Info(true);
            productInfo.BOM = new Info(true);
            productInfo.ERPBOM = new Info(true);
            productInfo.StdStartQty = new Info(true);
            productInfo.UOM = new Info(true);
            productInfo.isAttachImage = new Info(true);
            productInfo.StdStartLevel = new Info(true);
            productInfo.StdStartOwner = new Info(true);
            productInfo.StdStartReason = new Info(true);
            productInfo.StdStartQty = new Info(true);
            productInfo.StdStartUOM= new Info(true);

            AttachDocumentDetails_Info attachDocumentDetails_Info = new AttachDocumentDetails_Info();
            attachDocumentDetails_Info.Document = new Info(true);
            attachDocumentDetails_Info.DocumentDisplayName = new Info(true);
            attachDocumentDetails_Info.DocumentName = new Info(true);
            attachDocumentDetails_Info.FileName = new Info(true);
            attachDocumentDetails_Info.AttachmentType = new Info(true);
            productInfo.AttachDocumentDetails = attachDocumentDetails_Info;

            return _maintenanceTxn.ProductInfo(objectToChange, productInfo, IgnoreException);
        }
        public MfgOrderChanges GetMfgOrder(string MfgOrderName, bool IgnoreException = true)
        {
            NamedObjectRef objectToChange = new NamedObjectRef(MfgOrderName);
            return _maintenanceTxn.MfgOrderInfo(objectToChange, IgnoreException);
        }
        public NamedObjectRef[] ListMfgOrders(bool IgnoreException = true)
        {
            return _maintenanceTxn.MfgOrderInfo(IgnoreException);
        }
        public ERPRouteChanges GetERPRoute(string ERPRouteName, string ERPRouteRevision = "", bool IgnoreException = true)
        {
            RevisionedObjectRef objectToChange = new RevisionedObjectRef(ERPRouteName);
            if (ERPRouteName != "" && ERPRouteRevision != "")
            {
                objectToChange = new RevisionedObjectRef(ERPRouteName, ERPRouteRevision);
            }
            ERPRouteChanges_Info erpRouteInfo = new ERPRouteChanges_Info();
            erpRouteInfo.Name = new Info(true);
            erpRouteInfo.Description = new Info(true);
            erpRouteInfo.RouteStepItem = new Info(true);
            RouteStepChanges_Info routeStepChanges_Info = new RouteStepChanges_Info();
            routeStepChanges_Info.Name = new Info(true);
            routeStepChanges_Info.ERPOperation = new Info(true);
            routeStepChanges_Info.Sequence = new Info(true);
            erpRouteInfo.RouteSteps = routeStepChanges_Info;
            erpRouteInfo.Status = new Info(true);
            return _maintenanceTxn.ERPRouteInfo(objectToChange, erpRouteInfo, IgnoreException);
        }
        public WorkflowChanges GetWorkflow(string WorkflowName, string WorkflowRevision = "", bool IgnoreException = true)
        {
            RevisionedObjectRef objectToChange = new RevisionedObjectRef(WorkflowName);
            if (WorkflowName != "" && WorkflowRevision != "")
            {
                objectToChange = new RevisionedObjectRef(WorkflowName, WorkflowRevision);
            }
            WorkflowChanges_Info workflowInfo = new WorkflowChanges_Info();
            workflowInfo.Name = new Info(true);
            workflowInfo.Description = new Info(true);
            workflowInfo.ERPRoute = new Info(true);
            workflowInfo.FirstStep = new Info(true);
            StepChanges_Info stepChanges_Info = new StepChanges_Info();
            stepChanges_Info.DefaultPath = new Info(true);
            stepChanges_Info.Description = new Info(true);
            stepChanges_Info.Description1 = new Info(true);
            stepChanges_Info.Paths = new MovePathChanges_Info();
            stepChanges_Info.Paths.ToStep = new Info(true);
            stepChanges_Info.Paths.ReturnToStep = new Info(true);
            stepChanges_Info.Paths.FromStep = new Info(true);
            stepChanges_Info.Paths.IsDefaultPath = new Info(true);
            stepChanges_Info.Paths.DisplayName = new Info(true);
            stepChanges_Info.PathSelectors = new MovePathSelectorChanges_Info();
            stepChanges_Info.PathSelectors.DisplayName = new Info(true);
            stepChanges_Info.PathSelectors.Path = new Info(true);
            stepChanges_Info.Name = new Info(true);
            stepChanges_Info.RouteStep = new Info(true);
            stepChanges_Info.ReworkPaths = new ReworkPathChanges_Info();
            stepChanges_Info.ReworkPaths.Name = new Info(true);
            stepChanges_Info.ReworkPathSelectors = new ReworkPathSelectorChanges_Info();
            stepChanges_Info.ReworkPathSelectors.Path = new Info(true);
            stepChanges_Info.ReworkPathSelectors.DisplayName = new Info(true);
            workflowInfo.Steps = stepChanges_Info;
            workflowInfo.Status = new Info(true);

            return _maintenanceTxn.WorkflowInfo(objectToChange, workflowInfo, IgnoreException);
        }
        public ERPBOMChanges GetERPBOM(string ERPBOMName, string ERPBOMRevision = "", bool IgnoreException = true)
        {
            RevisionedObjectRef objectToChange = new RevisionedObjectRef(ERPBOMName);
            if (ERPBOMName != "" && ERPBOMRevision != "")
            {
                objectToChange = new RevisionedObjectRef(ERPBOMName, ERPBOMRevision);
            }
            ERPBOMChanges_Info erpbomInfo = new ERPBOMChanges_Info();
            erpbomInfo.Name = new Info(true);
            erpbomInfo.Description = new Info(true);
            erpbomInfo.ERPRoute = new Info(true);
            BOMMaterialListItemChanges_Info bOMMaterialListItemChanges_Info = new BOMMaterialListItemChanges_Info();
            bOMMaterialListItemChanges_Info.Name = new Info(true);
            bOMMaterialListItemChanges_Info.Product = new Info(true);
            bOMMaterialListItemChanges_Info.Description1 = new Info(true);
            bOMMaterialListItemChanges_Info.isProductDescription = new Info(true);
            bOMMaterialListItemChanges_Info.QtyRequired= new Info(true);
            bOMMaterialListItemChanges_Info.IssueControl = new Info(true);
            erpbomInfo.MaterialList = bOMMaterialListItemChanges_Info;
            erpbomInfo.Status = new Info(true);

            return (ERPBOMChanges)_maintenanceTxn.ERPBOMInfo(objectToChange, erpbomInfo, IgnoreException);
        }
    }
}
