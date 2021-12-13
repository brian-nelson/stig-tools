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
// named AssetRepo.cs
namespace ESC2.Module.System.Data.Repos
{
    public partial class AssetRepo : AbstractGuidRepo<ESC2.Module.System.Data.DataObjects.Asset>
    {
        public AssetRepo(IDataProvider dataProvider)
             : base(dataProvider)
        {
        }

        public override string SchemaName => "dbo";
        public override string TableName => "asset";

        public override string InsertSql => @"
            INSERT INTO [dbo].[asset] (
                [dbo].[asset].[AssetId],
                [dbo].[asset].[Name],
                [dbo].[asset].[Description],
                [dbo].[asset].[Status],
                [dbo].[asset].[HostName],
                [dbo].[asset].[ContactEmployeeId],
                [dbo].[asset].[OwningDepartmentId],
                [dbo].[asset].[ParentAssetId],
                [dbo].[asset].[AssetTypeId])
            VALUES ( 
                @Id,
                @Name,
                @Description,
                @Status,
                @HostName,
                @ContactEmployeeId,
                @OwningDepartmentId,
                @ParentAssetId,
                @AssetTypeId) ";

        public override string UpdateSql => @"
            UPDATE [dbo].[asset] 
            SET [dbo].[asset].[name]=@Name,
                [dbo].[asset].[description]=@Description,
                [dbo].[asset].[status]=@Status,
                [dbo].[asset].[host_name]=@HostName,
                [dbo].[asset].[contact_employee_id]=@ContactEmployeeId,
                [dbo].[asset].[owning_department_id]=@OwningDepartmentId,
                [dbo].[asset].[parent_asset_id]=@ParentAssetId,
                [dbo].[asset].[asset_type_id]=@AssetTypeId
            WHERE [dbo].[asset].[asset_id]=@Id ";

        public override string SelectSql => @"
            SELECT [dbo].[asset].[asset_id],
                   [dbo].[asset].[name],
                   [dbo].[asset].[description],
                   [dbo].[asset].[status],
                   [dbo].[asset].[host_name],
                   [dbo].[asset].[contact_employee_id],
                   [dbo].[asset].[owning_department_id],
                   [dbo].[asset].[parent_asset_id],
                   [dbo].[asset].[asset_type_id]
            FROM [dbo].[asset] ";

        public override ESC2.Module.System.Data.DataObjects.Asset ToObject(DataRow row)
        {
            var obj = new ESC2.Module.System.Data.DataObjects.Asset();
            obj.Id = row.GetGuid("asset_id");
            obj.Name = row.GetString("name");
            obj.Description = row.GetString("description");
            obj.Status = row.GetString("status");
            obj.HostName = row.GetString("host_name");
            obj.ContactEmployeeId = row.GetNullableGuid("contact_employee_id");
            obj.OwningDepartmentId = row.GetNullableGuid("owning_department_id");
            obj.ParentAssetId = row.GetNullableGuid("parent_asset_id");
            obj.AssetTypeId = row.GetGuid("asset_type_id");
            return obj;
        }

        public override List<DbQueryParameter> ToParameters(ESC2.Module.System.Data.DataObjects.Asset obj)
        {
            List<DbQueryParameter> parameters = new List<DbQueryParameter>();
            parameters.Add(new DbQueryParameter("Id", obj.Id, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("Name", obj.Name, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("Description", obj.Description, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("Status", obj.Status, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("HostName", obj.HostName, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("ContactEmployeeId", obj.ContactEmployeeId, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("OwningDepartmentId", obj.OwningDepartmentId, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("ParentAssetId", obj.ParentAssetId, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("AssetTypeId", obj.AssetTypeId, DbQueryParameterType.Guid));

            return parameters;
        }
    }
}
