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
// named SystemEventFacilityRepo.cs
namespace ESC2.Module.System.Data.Repos
{
    public partial class SystemEventFacilityRepo : AbstractIdentityRepo<ESC2.Module.System.Data.DataObjects.SystemEventFacility, Byte>
    {
        public SystemEventFacilityRepo(IDataProvider dataProvider)
             : base(dataProvider)
        {
        }

        public override string SchemaName => "dbo";
        public override string TableName => "system_event_facility";

        public override string InsertSql => @"
            INSERT INTO [dbo].[system_event_facility] (
                [dbo].[system_event_facility].[system_event_facility_id],
                [dbo].[system_event_facility].[name])
            VALUES ( 
                @Id,
                @Name) ";

        public override string UpdateSql => @"
            UPDATE [dbo].[system_event_facility] 
            SET [dbo].[system_event_facility].[name]=@Name
            WHERE [dbo].[system_event_facility].[system_event_facility_id]=@Id ";

        public override string SelectSql => @"
            SELECT [dbo].[system_event_facility].[system_event_facility_id],
                   [dbo].[system_event_facility].[name]
            FROM [dbo].[system_event_facility] ";

        public override ESC2.Module.System.Data.DataObjects.SystemEventFacility ToObject(DataRow row)
        {
            var obj = new ESC2.Module.System.Data.DataObjects.SystemEventFacility();
            obj.Id = row.GetByte("system_event_facility_id");
            obj.Name = row.GetString("name");
            return obj;
        }

        public override List<DbQueryParameter> ToParameters(ESC2.Module.System.Data.DataObjects.SystemEventFacility obj)
        {
            List<DbQueryParameter> parameters = new List<DbQueryParameter>();
            parameters.Add(new DbQueryParameter("Id", obj.Id, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("Name", obj.Name, DbQueryParameterType.String));

            return parameters;
        }
    }
}
