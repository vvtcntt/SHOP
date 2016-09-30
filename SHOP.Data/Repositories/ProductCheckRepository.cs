﻿using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IProductCheckRepository : IRepository<ProductCheck>
    {

    }
    public class ProductCheckRepository:RepositoryBase<ProductCheck>,IProductCheckRepository
    {
        public ProductCheckRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
