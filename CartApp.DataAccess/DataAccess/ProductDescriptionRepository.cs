﻿using CartApp.DataLayer;
using CartApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartApp.DataAccess.DataAccess;
using CartApp.DataAccess;

namespace CartApp.Business
{
    public class ProductDescriptionRepository : BaseRepositoryBL<ProductDescription>
    {
        public ProductDescriptionRepository(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {

        }
    }
}