﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Application.Features.Brands.Queries
{
    public class GetAllBrandsQueryResponse
    {
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
