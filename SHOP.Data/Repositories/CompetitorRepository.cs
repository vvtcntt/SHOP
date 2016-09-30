﻿using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface ICompetitorRepository : IRepository<Competitor> { }
    public class CompetitorRepository:RepositoryBase<Competitor>, ICompetitorRepository
    {
        public CompetitorRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}