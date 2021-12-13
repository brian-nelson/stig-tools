using System;
using System.Collections.Generic;
using System.Data;
using ESC2.Library.Data.Constants;
using ESC2.Library.Data.Repos;
using ESC2.Library.Data.Helpers;
using ESC2.Library.Data.Interfaces;
using ESC2.Library.Data.Objects;

// This file is generated from the database.  Do not manually edit.
// Generated by: https://github.com/brian-nelson/repo-generator
// To extend the class beyond a POCO, create a additional partial class
// named ImplementationFactRepo.cs
namespace ESC2.Module.System.Data.Repos
{
    public partial class ImplementationFactRepo : AbstractGuidRepo<ESC2.Module.System.Data.DataObjects.ImplementationFact>
    {
        public ImplementationFactRepo(IDataProvider dataProvider)
             : base(dataProvider)
        {
        }

        public override string SchemaName => "dbo";
        public override string TableName => "implementation_fact";

        public override string InsertSql => @"
            INSERT INTO [dbo].[implementation_fact] (
                [dbo].[implementation_fact].[ImplementationFactId],
                [dbo].[implementation_fact].[ImplementationId],
                [dbo].[implementation_fact].[AssetId],
                [dbo].[implementation_fact].[ImplementationGuideId],
                [dbo].[implementation_fact].[EmployeeId],
                [dbo].[implementation_fact].[StartedOnPeriodId],
                [dbo].[implementation_fact].[CompletedOnPeriodId],
                [dbo].[implementation_fact].[HoursToComplete])
            VALUES ( 
                @Id,
                @ImplementationId,
                @AssetId,
                @ImplementationGuideId,
                @EmployeeId,
                @StartedOnPeriodId,
                @CompletedOnPeriodId,
                @HoursToComplete) ";

        public override string UpdateSql => @"
            UPDATE [dbo].[implementation_fact] 
            SET [dbo].[implementation_fact].[implementation_id]=@ImplementationId,
                [dbo].[implementation_fact].[asset_id]=@AssetId,
                [dbo].[implementation_fact].[implementation_guide_id]=@ImplementationGuideId,
                [dbo].[implementation_fact].[employee_id]=@EmployeeId,
                [dbo].[implementation_fact].[started_on_period_id]=@StartedOnPeriodId,
                [dbo].[implementation_fact].[completed_on_period_id]=@CompletedOnPeriodId,
                [dbo].[implementation_fact].[hours_to_complete]=@HoursToComplete
            WHERE [dbo].[implementation_fact].[implementation_fact_id]=@Id ";

        public override string SelectSql => @"
            SELECT [dbo].[implementation_fact].[implementation_fact_id],
                   [dbo].[implementation_fact].[implementation_id],
                   [dbo].[implementation_fact].[asset_id],
                   [dbo].[implementation_fact].[implementation_guide_id],
                   [dbo].[implementation_fact].[employee_id],
                   [dbo].[implementation_fact].[started_on_period_id],
                   [dbo].[implementation_fact].[completed_on_period_id],
                   [dbo].[implementation_fact].[hours_to_complete]
            FROM [dbo].[implementation_fact] ";

        public override ESC2.Module.System.Data.DataObjects.ImplementationFact ToObject(DataRow row)
        {
            var obj = new ESC2.Module.System.Data.DataObjects.ImplementationFact();
            obj.Id = row.GetGuid("implementation_fact_id");
            obj.ImplementationId = row.GetGuid("implementation_id");
            obj.AssetId = row.GetGuid("asset_id");
            obj.ImplementationGuideId = row.GetGuid("implementation_guide_id");
            obj.EmployeeId = row.GetGuid("employee_id");
            obj.StartedOnPeriodId = row.GetLong("started_on_period_id");
            obj.CompletedOnPeriodId = row.GetLong("completed_on_period_id");
            obj.HoursToComplete = row.GetDouble("hours_to_complete");
            return obj;
        }

        public override List<DbQueryParameter> ToParameters(ESC2.Module.System.Data.DataObjects.ImplementationFact obj)
        {
            List<DbQueryParameter> parameters = new List<DbQueryParameter>();
            parameters.Add(new DbQueryParameter("Id", obj.Id, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("ImplementationId", obj.ImplementationId, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("AssetId", obj.AssetId, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("ImplementationGuideId", obj.ImplementationGuideId, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("EmployeeId", obj.EmployeeId, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("StartedOnPeriodId", obj.StartedOnPeriodId, DbQueryParameterType.Int64));
            parameters.Add(new DbQueryParameter("CompletedOnPeriodId", obj.CompletedOnPeriodId, DbQueryParameterType.Int64));
            parameters.Add(new DbQueryParameter("HoursToComplete", obj.HoursToComplete, DbQueryParameterType.Double));

            return parameters;
        }
    }
}
