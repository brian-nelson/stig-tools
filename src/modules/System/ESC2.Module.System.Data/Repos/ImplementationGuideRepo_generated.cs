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
namespace ESC2.Module.System.Data.Repos
{
    public partial class ImplementationGuideRepo : AbstractGuidRepo<ESC2.Module.System.Data.DataObjects.ImplementationGuide>
    {
        public ImplementationGuideRepo(IDataProvider dataProvider)
             : base(dataProvider)
        {
        }

        public override string SchemaName => "dbo";
        public override string TableName => "implementation_guide";

        public override string InsertSql => @"
            INSERT INTO [dbo].[implementation_guide] (
                [dbo].[implementation_guide].[ImplementationGuideId],
                [dbo].[implementation_guide].[Number],
                [dbo].[implementation_guide].[Type])
            VALUES ( 
                @Id,
                @Number,
                @Type) ";

        public override string UpdateSql => @"
            UPDATE [dbo].[implementation_guide] 
            SET [dbo].[implementation_guide].[number]=@Number,
                [dbo].[implementation_guide].[type]=@Type
            WHERE [dbo].[implementation_guide].[implementation_guide_id]=@Id ";

        public override string SelectSql => @"
            SELECT [dbo].[implementation_guide].[implementation_guide_id],
                   [dbo].[implementation_guide].[number],
                   [dbo].[implementation_guide].[type]
            FROM [dbo].[implementation_guide] ";

        public override ESC2.Module.System.Data.DataObjects.ImplementationGuide ToObject(DataRow row)
        {
            var obj = new ESC2.Module.System.Data.DataObjects.ImplementationGuide();
            obj.Id = row.GetGuid("implementation_guide_id");
            obj.Number = row.GetString("number");
            obj.Type = row.GetString("type");
            return obj;
        }

        public override List<DbQueryParameter> ToParameters(ESC2.Module.System.Data.DataObjects.ImplementationGuide obj)
        {
            List<DbQueryParameter> parameters = new List<DbQueryParameter>();
            parameters.Add(new DbQueryParameter("Id", obj.Id, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("Number", obj.Number, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("Type", obj.Type, DbQueryParameterType.String));

            return parameters;
        }
    }
}
