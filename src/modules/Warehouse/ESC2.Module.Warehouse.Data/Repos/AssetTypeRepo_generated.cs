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
namespace ESC2.Module.System.Data.Repos
{
    public partial class AssetTypeRepo : AbstractGuidRepo<ESC2.Module.System.Data.DataObjects.AssetType>
    {
        public AssetTypeRepo(IDataProvider dataProvider)
             : base(dataProvider)
        {
        }

        public override string SchemaName => "dbo";
        public override string TableName => "asset_type";

        public override string InsertSql => @"
            INSERT INTO [dbo].[asset_type] (
                [dbo].[asset_type].[asset_type_id],
                [dbo].[asset_type].[asset_group_id],
                [dbo].[asset_type].[implementation_guide_id],
                [dbo].[asset_type].[name])
            VALUES ( 
                @Id,
                @AssetGroupId,
                @ImplementationGuideId,
                @Name) ";

        public override string UpdateSql => @"
            UPDATE [dbo].[asset_type] 
            SET [dbo].[asset_type].[asset_group_id]=@AssetGroupId,
                [dbo].[asset_type].[implementation_guide_id]=@ImplementationGuideId,
                [dbo].[asset_type].[name]=@Name
            WHERE [dbo].[asset_type].[asset_type_id]=@Id ";

        public override string SelectSql => @"
            SELECT [dbo].[asset_type].[asset_type_id],
                   [dbo].[asset_type].[asset_group_id],
                   [dbo].[asset_type].[implementation_guide_id],
                   [dbo].[asset_type].[name]
            FROM [dbo].[asset_type] ";

        public override ESC2.Module.System.Data.DataObjects.AssetType ToObject(DataRow row)
        {
            var obj = new ESC2.Module.System.Data.DataObjects.AssetType();
            obj.Id = row.GetGuid("asset_type_id");
            obj.AssetGroupId = row.GetGuid("asset_group_id");
            obj.ImplementationGuideId = row.GetGuid("implementation_guide_id");
            obj.Name = row.GetString("name");
            return obj;
        }

        public override List<DbQueryParameter> ToParameters(ESC2.Module.System.Data.DataObjects.AssetType obj)
        {
            List<DbQueryParameter> parameters = new List<DbQueryParameter>();
            parameters.Add(new DbQueryParameter("Id", obj.Id, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("AssetGroupId", obj.AssetGroupId, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("ImplementationGuideId", obj.ImplementationGuideId, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("Name", obj.Name, DbQueryParameterType.String));

            return parameters;
        }
    }
}