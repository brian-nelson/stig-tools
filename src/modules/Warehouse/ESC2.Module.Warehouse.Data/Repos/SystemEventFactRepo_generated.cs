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
// named SystemEventFactRepo.cs
namespace ESC2.Module.System.Data.Repos
{
    public partial class SystemEventFactRepo : AbstractGuidRepo<ESC2.Module.System.Data.DataObjects.SystemEventFact>
    {
        public SystemEventFactRepo(IDataProvider dataProvider)
             : base(dataProvider)
        {
        }

        public override string SchemaName => "dbo";
        public override string TableName => "system_event_fact";

        public override string InsertSql => @"
            INSERT INTO [dbo].[system_event_fact] (
                [dbo].[system_event_fact].[system_event_fact_id],
                [dbo].[system_event_fact].[asset_id],
                [dbo].[system_event_fact].[period_id],
                [dbo].[system_event_fact].[system_event_severity_id],
                [dbo].[system_event_fact].[system_event_facility_id],
                [dbo].[system_event_fact].[count])
            VALUES ( 
                @Id,
                @AssetId,
                @PeriodId,
                @SystemEventSeverityId,
                @SystemEventFacilityId,
                @Count) ";

        public override string UpdateSql => @"
            UPDATE [dbo].[system_event_fact] 
            SET [dbo].[system_event_fact].[asset_id]=@AssetId,
                [dbo].[system_event_fact].[period_id]=@PeriodId,
                [dbo].[system_event_fact].[system_event_severity_id]=@SystemEventSeverityId,
                [dbo].[system_event_fact].[system_event_facility_id]=@SystemEventFacilityId,
                [dbo].[system_event_fact].[count]=@Count
            WHERE [dbo].[system_event_fact].[system_event_fact_id]=@Id ";

        public override string SelectSql => @"
            SELECT [dbo].[system_event_fact].[system_event_fact_id],
                   [dbo].[system_event_fact].[asset_id],
                   [dbo].[system_event_fact].[period_id],
                   [dbo].[system_event_fact].[system_event_severity_id],
                   [dbo].[system_event_fact].[system_event_facility_id],
                   [dbo].[system_event_fact].[count]
            FROM [dbo].[system_event_fact] ";

        public override ESC2.Module.System.Data.DataObjects.SystemEventFact ToObject(DataRow row)
        {
            var obj = new ESC2.Module.System.Data.DataObjects.SystemEventFact();
            obj.Id = row.GetGuid("system_event_fact_id");
            obj.AssetId = row.GetGuid("asset_id");
            obj.PeriodId = row.GetLong("period_id");
            obj.SystemEventSeverityId = row.GetGuid("system_event_severity_id");
            obj.SystemEventFacilityId = row.GetGuid("system_event_facility_id");
            obj.Count = row.GetLong("count");
            return obj;
        }

        public override List<DbQueryParameter> ToParameters(ESC2.Module.System.Data.DataObjects.SystemEventFact obj)
        {
            List<DbQueryParameter> parameters = new List<DbQueryParameter>();
            parameters.Add(new DbQueryParameter("Id", obj.Id, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("AssetId", obj.AssetId, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("PeriodId", obj.PeriodId, DbQueryParameterType.Int64));
            parameters.Add(new DbQueryParameter("SystemEventSeverityId", obj.SystemEventSeverityId, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("SystemEventFacilityId", obj.SystemEventFacilityId, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("Count", obj.Count, DbQueryParameterType.Int64));

            return parameters;
        }
    }
}