 namespace Terrasoft.Configuration
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Activation;
    using System.ServiceModel.Web;
    using System.Web.SessionState;
    using Terrasoft.Core.DB;
    using Terrasoft.Web.Common;
    [ServiceContract] //decorator that tells compiler this class is the service
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class YachtService: BaseService, IReadOnlySessionState //IReadOnlySessionState readonly session states, interface used for multithreading, return promise, not modify session
    {
        [OperationContract] // decorator tells not normal method its endpoint
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]

	public decimal GetMaxPriceByDriveTypeId(string driveTypeId)
        {
            if (string.IsNullOrEmpty(driveTypeId))
            {
                return -1;
            }
            Select select = new Select(UserConnection)
                 .Column(Func.Max("UsrPrice"))
                .From("UsrYacht")
                .Where("UsrDriveTypeId").IsEqual(Column.Parameter(new Guid(driveTypeId)))
                .And("UsrStatusId").IsEqual(Column.Parameter(new Guid("bb53835f-3b54-4e32-b782-d9e924a9440b"))) // 1. Operational
                as Select;
            decimal result = select.ExecuteScalar<decimal>(); // ExecuteScalar return first entry
            return result;
        }


        [OperationContract] // decorator tells not normal method its endpoint
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]

        public decimal GetAvgPriceByDriveTypeId(string driveTypeId)
	        {
	            if (string.IsNullOrEmpty(driveTypeId))
	            {
	                return -1;
	            }
	            Select select = new Select(UserConnection)
	                .Column(Func.Avg("UsrPrice"))
	                .From("UsrYacht")
	                .Where("UsrDriveTypeId").IsEqual(Column.Parameter(new Guid(driveTypeId)))
	                .And("UsrStatusId").IsEqual(Column.Parameter(new Guid("bb53835f-3b54-4e32-b782-d9e924a9440b"))) // 1. Operational
	                as Select;
	            decimal result = select.ExecuteScalar<decimal>(); // ExecuteScalar return first entry
	            return result;
	        }
		
        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public string GetExample()
        {
            return "OK!";
        }

    }
}