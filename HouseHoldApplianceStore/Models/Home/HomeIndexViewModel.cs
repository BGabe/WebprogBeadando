using HouseHoldApplianceStore.DAL;
using HouseHoldApplianceStore.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HouseHoldApplianceStore.Models.Home
{
    public class HomeIndexViewModel
    {
        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();
        public dbStoreEntities context = new dbStoreEntities();
        public IEnumerable<Tbl_Product> ListOfProducts { get; set; }
        public HomeIndexViewModel CreateModel(string search)
        {
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@search",search??(object)DBNull.Value)
            };
            IEnumerable<Tbl_Product> data = context.Database.SqlQuery<Tbl_Product>("GetBySearch @search", param).ToList();
            return new HomeIndexViewModel()
            {

                ListOfProducts = data
            };
        }
    } 
}