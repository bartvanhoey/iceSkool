﻿using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BoostR.Sql;
using BoostR.SqlCqrs.Products;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BoostR.Web.Controllers
{
    public class GetProducts
    {
        [Route("api/products")]
        public class Query : IRequest<ProductsViewModel>
        {
        }

        public class ProductsViewModel
        {
            public IEnumerable<ProductDto> Products { get; set; }
            public bool CreateEnabled { get; set; }
        }

        public class QueryHandler : IRequestHandler<Query, ProductsViewModel>
        {
            public NorthwindDbContext Context { get; }

            public QueryHandler(NorthwindDbContext context)
            {
                Context = context;
            }

            public async Task<ProductsViewModel> Handle(Query qry, CancellationToken cancellationToken)
            {
                return new ProductsViewModel
                {
                    Products = await Context.Products.Select(ProductDto.Projection).OrderBy(p => p.ProductName).ToListAsync(cancellationToken),
                    CreateEnabled = true
                };
            }
        }
    }
}
