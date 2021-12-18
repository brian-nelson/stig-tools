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
// named ImplementationGuideRepo.cs
namespace ESC2.Module.System.Data.Repos.Operational
{
    public partial class ImplementationGuideRepo : AbstractDataRepo<ESC2.Module.System.Data.DataObjects.Operational.ImplementationGuide, Guid>
    {
        public ImplementationGuideRepo(IDataProvider dataProvider)
             : base(dataProvider)
        {
        }

        public override string SchemaName => "operational";
        public override string TableName => "implementation_guide";

        public override string InsertSql => @"
            INSERT INTO [operational].[implementation_guide] (
                [operational].[implementation_guide].[implementation_guide_id],
                [operational].[implementation_guide].[number],
                [operational].[implementation_guide].[type],
                [operational].[implementation_guide].[created_by_id],
                [operational].[implementation_guide].[created_on],
                [operational].[implementation_guide].[last_modified_by_id],
                [operational].[implementation_guide].[last_modified_on])
            VALUES ( 
                @Id,
                @Number,
                @Type,
                @CreatedById,
                @CreatedOn,
                @LastModifiedById,
                @LastModifiedOn) ";

        public override string UpdateSql => @"
            UPDATE [operational].[implementation_guide] 
            SET [operational].[implementation_guide].[number]=@Number,
                [operational].[implementation_guide].[type]=@Type,
                [operational].[implementation_guide].[created_by_id]=@CreatedById,
                [operational].[implementation_guide].[created_on]=@CreatedOn,
                [operational].[implementation_guide].[last_modified_by_id]=@LastModifiedById,
                [operational].[implementation_guide].[last_modified_on]=@LastModifiedOn
            WHERE [operational].[implementation_guide].[implementation_guide_id]=@Id ";

        public override string SelectSql => @"
            SELECT [operational].[implementation_guide].[implementation_guide_id],
                   [operational].[implementation_guide].[number],
                   [operational].[implementation_guide].[type],
                   [operational].[implementation_guide].[created_by_id],
                   [operational].[implementation_guide].[created_on],
                   [operational].[implementation_guide].[last_modified_by_id],
                   [operational].[implementation_guide].[last_modified_on]
            FROM [operational].[implementation_guide] ";

        public override ESC2.Module.System.Data.DataObjects.Operational.ImplementationGuide ToObject(DataRow row)
        {
            var obj = new ESC2.Module.System.Data.DataObjects.Operational.ImplementationGuide();
            obj.Id = row.GetGuid("implementation_guide_id");
            obj.Number = row.GetString("number");
            obj.Type = row.GetString("type");
            obj.CreatedById = row.GetGuid("created_by_id");
            obj.CreatedOn = row.GetDateTime("created_on");
            obj.LastModifiedById = row.GetGuid("last_modified_by_id");
            obj.LastModifiedOn = row.GetDateTime("last_modified_on");
            return obj;
        }

        public override List<DbQueryParameter> ToParameters(ESC2.Module.System.Data.DataObjects.Operational.ImplementationGuide obj)
        {
            List<DbQueryParameter> parameters = new List<DbQueryParameter>();
            parameters.Add(new DbQueryParameter("Id", obj.Id, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("Number", obj.Number, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("Type", obj.Type, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("CreatedById", obj.CreatedById, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("CreatedOn", obj.CreatedOn, DbQueryParameterType.DateTime));
            parameters.Add(new DbQueryParameter("LastModifiedById", obj.LastModifiedById, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("LastModifiedOn", obj.LastModifiedOn, DbQueryParameterType.DateTime));

            return parameters;
        }
    }
}
