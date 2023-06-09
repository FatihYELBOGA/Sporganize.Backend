﻿using Sporganize.Configurations;
using Sporganize.Generics;
using Sporganize.Models;

namespace Sporganize.Repositories
{
    public class ProvinceRepository : GenericRepository<Province>, IProvinceRepository
    {
        public ProvinceRepository(DataContext dataContext) : base(dataContext)
        {

        }

    }

}
