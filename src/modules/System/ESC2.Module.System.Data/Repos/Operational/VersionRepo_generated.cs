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
// named VersionRepo.cs
namespace ESC2.Module.System.Data.Repos.Operational
{
    public partial class VersionRepo : AbstractDataRepo<ESC2.Module.System.Data.DataObjects.Operational.Version, Guid>
    {
        public VersionRepo(IDataProvider dataProvider)
             : base(dataProvider)
        {
        }

        public override string SchemaName => "operational";
        public override string TableName => "version";

        public override string InsertSql => @"
            INSERT INTO [operational].[version] (
                [operational].[version].[version_id],
                [operational].[version].[number],
                [operational].[version].[status],
                [operational].[version].[status_date],
                [operational].[version].[title],
                [operational].[version].[description],
                [operational].[version].[publisher],
                [operational].[version].[source],
                [operational].[version].[filename],
                [operational].[version].[implementation_guide_id],
                [operational].[version].[created_by_id],
                [operational].[version].[created_on],
                [operational].[version].[last_modified_by_id],
                [operational].[version].[last_modified_on])
            VALUES ( 
                @Id,
                @Number,
                @Status,
                @StatusDate,
                @Title,
                @Description,
                @Publisher,
                @Source,
                @Filename,
                @ImplementationGuideId,
                @CreatedById,
                @CreatedOn,
                @LastModifiedById,
                @LastModifiedOn) ";

        public override string UpdateSql => @"
            UPDATE [operational].[version] 
            SET [operational].[version].[number]=@Number,
                [operational].[version].[status]=@Status,
                [operational].[version].[status_date]=@StatusDate,
                [operational].[version].[title]=@Title,
                [operational].[version].[description]=@Description,
                [operational].[version].[publisher]=@Publisher,
                [operational].[version].[source]=@Source,
                [operational].[version].[filename]=@Filename,
                [operational].[version].[implementation_guide_id]=@ImplementationGuideId,
                [operational].[version].[created_by_id]=@CreatedById,
                [operational].[version].[created_on]=@CreatedOn,
                [operational].[version].[last_modified_by_id]=@LastModifiedById,
                [operational].[version].[last_modified_on]=@LastModifiedOn
            WHERE [operational].[version].[version_id]=@Id ";

        public override string SelectSql => @"
            SELECT [operational].[version].[version_id],
                   [operational].[version].[number],
                   [operational].[version].[status],
                   [operational].[version].[status_date],
                   [operational].[version].[title],
                   [operational].[version].[description],
                   [operational].[version].[publisher],
                   [operational].[version].[source],
                   [operational].[version].[filename],
                   [operational].[version].[implementation_guide_id],
                   [operational].[version].[created_by_id],
                   [operational].[version].[created_on],
                   [operational].[version].[last_modified_by_id],
                   [operational].[version].[last_modified_on]
            FROM [operational].[version] ";

        public override string DeleteSql => @"DELETE FROM [operational].[version] WHERE [operational].[version].[version_id] = @Id";

        public override string GetByIdSql => $@"{SelectSql} WHERE [operational].[version].[version_id = @Id";
        public override ESC2.Module.System.Data.DataObjects.Operational.Version ToObject(DataRow row)
        {
            var obj = new ESC2.Module.System.Data.DataObjects.Operational.Version();
            obj.Id = row.GetGuid("version_id");
            obj.Number = row.GetString("number");
            obj.Status = row.GetString("status");
            obj.StatusDate = row.GetDateTime("status_date");
            obj.Title = row.GetString("title");
            obj.Description = row.GetString("description");
            obj.Publisher = row.GetString("publisher");
            obj.Source = row.GetString("source");
            obj.Filename = row.GetString("filename");
            obj.ImplementationGuideId = row.GetGuid("implementation_guide_id");
            obj.CreatedById = row.GetGuid("created_by_id");
            obj.CreatedOn = row.GetDateTime("created_on");
            obj.LastModifiedById = row.GetGuid("last_modified_by_id");
            obj.LastModifiedOn = row.GetDateTime("last_modified_on");
            return obj;
        }

        public override List<DbQueryParameter> ToParameters(ESC2.Module.System.Data.DataObjects.Operational.Version obj)
        {
            List<DbQueryParameter> parameters = new List<DbQueryParameter>();
            parameters.Add(new DbQueryParameter("Id", obj.Id, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("Number", obj.Number, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("Status", obj.Status, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("StatusDate", obj.StatusDate, DbQueryParameterType.DateTime));
            parameters.Add(new DbQueryParameter("Title", obj.Title, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("Description", obj.Description, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("Publisher", obj.Publisher, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("Source", obj.Source, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("Filename", obj.Filename, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("ImplementationGuideId", obj.ImplementationGuideId, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("CreatedById", obj.CreatedById, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("CreatedOn", obj.CreatedOn, DbQueryParameterType.DateTime));
            parameters.Add(new DbQueryParameter("LastModifiedById", obj.LastModifiedById, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("LastModifiedOn", obj.LastModifiedOn, DbQueryParameterType.DateTime));

            return parameters;
        }
    }
}
