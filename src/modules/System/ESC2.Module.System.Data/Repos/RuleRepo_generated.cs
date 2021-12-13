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
// named RuleRepo.cs
namespace ESC2.Module.System.Data.Repos
{
    public partial class RuleRepo : AbstractGuidRepo<ESC2.Module.System.Data.DataObjects.Rule>
    {
        public RuleRepo(IDataProvider dataProvider)
             : base(dataProvider)
        {
        }

        public override string SchemaName => "dbo";
        public override string TableName => "rule";

        public override string InsertSql => @"
            INSERT INTO [dbo].[rule] (
                [dbo].[rule].[RuleId],
                [dbo].[rule].[Number],
                [dbo].[rule].[Severity],
                [dbo].[rule].[Version],
                [dbo].[rule].[Title],
                [dbo].[rule].[Discussion],
                [dbo].[rule].[Fix],
                [dbo].[rule].[Check],
                [dbo].[rule].[Cci],
                [dbo].[rule].[VersionId])
            VALUES ( 
                @Id,
                @Number,
                @Severity,
                @Version,
                @Title,
                @Discussion,
                @Fix,
                @Check,
                @Cci,
                @VersionId) ";

        public override string UpdateSql => @"
            UPDATE [dbo].[rule] 
            SET [dbo].[rule].[number]=@Number,
                [dbo].[rule].[severity]=@Severity,
                [dbo].[rule].[version]=@Version,
                [dbo].[rule].[title]=@Title,
                [dbo].[rule].[discussion]=@Discussion,
                [dbo].[rule].[fix]=@Fix,
                [dbo].[rule].[check]=@Check,
                [dbo].[rule].[cci]=@Cci,
                [dbo].[rule].[version_id]=@VersionId
            WHERE [dbo].[rule].[rule_id]=@Id ";

        public override string SelectSql => @"
            SELECT [dbo].[rule].[rule_id],
                   [dbo].[rule].[number],
                   [dbo].[rule].[severity],
                   [dbo].[rule].[version],
                   [dbo].[rule].[title],
                   [dbo].[rule].[discussion],
                   [dbo].[rule].[fix],
                   [dbo].[rule].[check],
                   [dbo].[rule].[cci],
                   [dbo].[rule].[version_id]
            FROM [dbo].[rule] ";

        public override ESC2.Module.System.Data.DataObjects.Rule ToObject(DataRow row)
        {
            var obj = new ESC2.Module.System.Data.DataObjects.Rule();
            obj.Id = row.GetGuid("rule_id");
            obj.Number = row.GetString("number");
            obj.Severity = row.GetString("severity");
            obj.Version = row.GetString("version");
            obj.Title = row.GetString("title");
            obj.Discussion = row.GetString("discussion");
            obj.Fix = row.GetString("fix");
            obj.Check = row.GetString("check");
            obj.Cci = row.GetString("cci");
            obj.VersionId = row.GetGuid("version_id");
            return obj;
        }

        public override List<DbQueryParameter> ToParameters(ESC2.Module.System.Data.DataObjects.Rule obj)
        {
            List<DbQueryParameter> parameters = new List<DbQueryParameter>();
            parameters.Add(new DbQueryParameter("Id", obj.Id, DbQueryParameterType.Guid));
            parameters.Add(new DbQueryParameter("Number", obj.Number, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("Severity", obj.Severity, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("Version", obj.Version, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("Title", obj.Title, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("Discussion", obj.Discussion, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("Fix", obj.Fix, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("Check", obj.Check, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("Cci", obj.Cci, DbQueryParameterType.String));
            parameters.Add(new DbQueryParameter("VersionId", obj.VersionId, DbQueryParameterType.Guid));

            return parameters;
        }
    }
}
