using System;
using System.Collections.Generic;
using System.Data;
using ESC2.Library.Data.Constants;
using ESC2.Library.Data.Helpers;
using ESC2.Library.Data.Interfaces;
using ESC2.Library.Data.Objects;

// This file is generated from the database.  Do not manually edit.
// Generated by: https://github.com/brian-nelson/repo-generator

namespace ESC2.Library.Data.Repos
{
    public abstract class AbstractIdentityRepo<T> : IIdentityRepo<T>
        where T : IIdentityObject
    {
        protected readonly IDataProvider DataProvider;
        protected AbstractIdentityRepo(IDataProvider dataProvider)
        {
            DataProvider = dataProvider;
        }

        public abstract string SchemaName { get; }
        public abstract string TableName { get; }
        public abstract T ToObject(DataRow row);
        public abstract List<DbQueryParameter> ToParameters(T obj);
        public abstract string InsertSql { get; }
        public abstract string UpdateSql { get; }
        public abstract string SelectSql { get; }

        public void Delete(long id)
        {
            var sql = "DELETE FROM [{SchemaName}].[{TableName}] WHERE [{SchemaName}].[{TableName}].[{TableName}_id] = @Id";
            var parameters = new List<DbQueryParameter>()
            {
                new DbQueryParameter("Id", id, DbQueryParameterType.Int64)
            };
            DataProvider.Execute(sql, parameters);
        }

        public T GetById(long id)
        {
            var sql = "{SelectSql} WHERE [{SchemaName}].[{TableName}].[{TableName}_id] = @Id";
            var parameters = new List<DbQueryParameter>()
            {
                new DbQueryParameter("Id", id, DbQueryParameterType.Int64)
            };
            var dt = DataProvider.GetData(sql, parameters);
            if (dt != null
                && dt.Rows.Count > 0)
            {
                return ToObject(dt.Rows[0]);
            }

            return default(T);
        }

        protected long Insert(T obj)
        {
            var parameters = ToParameters(obj);
            DataProvider.Execute(InsertSql, parameters);
            return 0;
        }

        protected void Update(T obj)
        {
            var parameters = ToParameters(obj);
            DataProvider.Execute(UpdateSql, parameters);
        }

        public long Save(T obj)
        {
            if (Exists(obj.Id))
            {
                Update(obj);
                return obj.Id;
            }
            else
            {
                long id = Insert(obj);
                obj.Id = id;
                return obj.Id;
            }
        }

        public List<T> GetList(
            string sql,
            List<DbQueryParameter> parameters = null,
            int timeout = 10)
        {
            if (parameters == null)
            {
                parameters = new List<DbQueryParameter>();
            }

            var table = DataProvider.GetData(sql, parameters, timeout);

            var output = new List<T>();

            foreach (DataRow row in table.Rows)
            {
                var obj = ToObject(row);
                output.Add(obj);
            }

            return output;
        }

        public object GetValue(
            string sql,
            string column,
            List<DbQueryParameter> parameters,
            int timeout = 30)
        {
            var table = DataProvider.GetData(sql, parameters, timeout);

            if (table.Rows.Count > 0)
            {
                var row = table.Rows[0];
                return row[column];
            }

            return null;
        }

        public T GetFirstOrDefault(
            string sql,
            List<DbQueryParameter> parameters = null,
            int timeout = 10)
        {
            var table = DataProvider.GetData(sql, parameters, timeout);

            if (table.Rows.Count > 0)
            {
                var obj = ToObject(table.Rows[0]);
                return obj;
            }

            return default(T);
        }

        public long GetCount()
        {
            var sql = $"SELECT COUNT(*) AS row_count FROM [{SchemaName}].[{TableName}]";
            long result = Convert.ToInt64(GetValue(sql, "row_count", null));
            return result;
        }

        public bool Exists(long id)
        {
            var sql = $"SELECT COUNT(*) AS row_count FROM [{SchemaName}].[{TableName}]"
                    + $"WHERE [{SchemaName}].[{TableName}].[{TableName}_id] = @Id";

            var parameters = new List<DbQueryParameter>()
            {
                new DbQueryParameter("Id", id, DbQueryParameterType.Int64)
            };

            var dt = DataProvider.GetData(sql, parameters);

            if (dt != null
                && dt.Rows.Count > 0)
            {
                var rowCount = dt.Rows[0].GetLong("row_count");

                if (rowCount > 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
