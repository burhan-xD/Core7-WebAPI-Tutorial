﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Application.Interfaces.RedisCache;

namespace WebApi.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductQueryRequest : IRequest<IList<GetAllProductQueryResponse>>, ICacheableQuery
    {
        public string CacheKey => "GetAllProducts";

        public double CacheTime => 60;
    }
}
