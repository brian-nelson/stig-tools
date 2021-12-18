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
// named AssetTypeRepo.cs
namespace ESC2.Module.System.Data.Repos.Operational
{
    public partial class AssetTypeRepo : AbstractDataRepo<ESC2.Module.System.Data.DataObjects.Operational.AssetType, Guid>
    {
        public AssetTypeRepo(IDataProvider dataProvider)
             : base(dataProvider)
        {
        }

        public override string SchemaName => "operational";
        public override string TableName => "asset_type";

        public override string InsertSql => @"
            INSERT INTO [operational].[asset_type] (
                [operational].[asset_type].[asset_type_id],
                [operational].[asset_type].[name],
                [operational].[asset_type].[description],
                [operational].[asset_type].[manufacturer],
                [operational].[asset_type].[model],
                [operational].[asset_type].[version],
                [operational].[asset_type].[implementation_guide_id],
                [operational].[asset_type].[asset_group_id],
                [operational].[asset_type].[created_by_id],
                [operational].[asset_type].[created_on],
                [operational].[asset_type].[last_modified_by_id],
                [operational].[asset_type].[last_modified_on])
            VALUES ( 
                @Id,
                @Name,
                @Description,
                @Manufacturer,
                @Model,
                @Version,
                @ImplementationGuideId,
                @AssetGroupId,
                @CreatedById,
                @CreatedOn,
                @LastModifiedById,
                @LastModifiedOn) ";

        public override string UpdateSql => @"
            UPDATE [operational].[asset_type] 
            SET [operational].[asset_type].[name]=@Name,
                [operational].[asset_type].[description]=@Description,
                [operational].[asset_type].[manufacturer]=@Manufacturer,
                [operational].[asset_type].[model]=@Model,
                [operational].[asset_type].[version]=@Version,
                [operational].[asset_type].[implementation_guide_id]=@ImplementationGuideId,
                [operational].[asset_type].[asset_group_id]=@AssetGroupId,
                [operational].[asset_type].[created_by_id]=@CreatedById,
                [operational].[asset_type].[created_on]=@CreatedOn,
                [operational].[asset_type].[last_modified_by_id]=@LastModifiedById,
                [operational].[asset_type].[last_modified_on]=@LastModifiedOn
            WHERE [operational].[asset_type].[asset_type_id]=@Id ";

        public override string SelectSql => @"
            SELECT [operational].[asset_type].[asset_type_id],
                   [operational].[asset_type].[name],
                   [operational].[asset_type].[description],
                   [operational].[asset_type].[manufacturer],
                   [operational].[asset_type].[model],
                   [operational].[asset_type].[version],
                   [operational].[asset_type].[implementation_guide_id],
                   [operational].[asset_type].[asset_group_id],
                   [operational].[asset_type].[created_by_id],
                   [operational].[asset_type].[created_on],
                   [operational].[asset_type].[last_modified_by_id],
                   [operational].[asset_type].[last_modified_on]
            FROM [operational].[asset_type] ";

        public override ESC2.Module.System.Data.DataObjects.Operational.AssetType ToObject(DataRow row)
        {
            var obj = new ESC2.Module.System.Data.DataObjects.Operational.AssetType();
            obj.Id = row.GetGuid("asset_type_id");
            obj.Name = row.GetString("name");
            obj.Description = row.GetString("description");
            obj.Manufacturer = row.GetString("manufacturer");
            obj.Model = row.GetString("model");
            obj.Version = row.GetString("version");
            obj.ImplementationGuideId = row.GetNullableGuid("implementation_guide_id");
            obj.AssetGroupId = row.GetGuid("asset_group_id");
            obj.CreatedById = row.GetGuid("created_by_id");
            obj.CreatedOn = row.GetDateTime("created_on");
            obj.LastModifiedById = row.GetGuid("last_modified_by_id");
            obj.LastModifiedOn = row.GetDateTime("last_modified_on");
            return obj;
        }

        public override List<DbQueryParameter> ToParameters(ESC2.Module.System.Data.DataObjects.Operational.AssetType obj)
        {
            List<DbQueryParameter> parameters = new List<DbQueryParameter>();
            parameters.Add(new DbQueryParameter("Id", obj.Id, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("Name", obj.Name, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("Description", obj.Description, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("Manufacturer", obj.Manufacturer, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("Model", obj.Model, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("Version", obj.Version, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("ImplementationGuideId", obj.ImplementationGuideId, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("AssetGroupId", obj.AssetGroupId, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("CreatedById", obj.CreatedById, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("CreatedOn", obj.CreatedOn, DbQueryParameterType.DateTime));
            parameters.Add(new DbQueryParameter("LastModifiedById", obj.LastModifiedById, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("LastModifiedOn", obj.LastModifiedOn, DbQueryParameterType.DateTime));

            return parameters;
        }
    }
}