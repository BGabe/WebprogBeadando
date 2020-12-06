using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace HouseHoldApplianceStore.Repository
{
    public interface IRepository<Tbl_Entitiy> where Tbl_Entitiy:class
    {
        IEnumerable<Tbl_Entitiy> GetAllRecords();
        IQueryable<Tbl_Entitiy> GetAllRecordsIQueryable();
        int GetAllRecordCount();
        void Add(Tbl_Entitiy entitiy);
        void Update(Tbl_Entitiy entitiy);
        void UpdateByWhereClause(Expression<Func<Tbl_Entitiy, bool>> wherePredict, Action<Tbl_Entitiy> ForEachPredict);
        Tbl_Entitiy GetFirstOrDefault(int recordId);
        void Remove(Tbl_Entitiy entitiy);
        void RemoveByWhereClause(Expression<Func<Tbl_Entitiy, bool>> wherePredict);
        void RemoveRangeByWhereClause(Expression<Func<Tbl_Entitiy, bool>> wherePredict);
        void InactiveAndDeleteMarkByWhereClause(Expression<Func<Tbl_Entitiy, bool>> wherePredict, Action<Tbl_Entitiy> ForEachPredict);
        Tbl_Entitiy GetFirstOrDefaultByParameter(Expression<Func<Tbl_Entitiy, bool>> wherePredict);
        IEnumerable<Tbl_Entitiy> GetListParameter(Expression<Func<Tbl_Entitiy, bool>> wherePredict);
        IEnumerable<Tbl_Entitiy> GetResultBySqlProcedure(string query, params object[] parameters);
        IEnumerable<Tbl_Entitiy> GetRecordsToShow(int PageNo, int PageSize, int CurrentPage, Expression<Func<Tbl_Entitiy, bool>> wherePredict, Expression<Func<Tbl_Entitiy, int>> orderByPredict);

    }
}