using Core.Models;
using Core.Specifications.Implementation.ModelSpecification;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Specifications.Implementation
{
    public class ProductWithFiltersForCountSpecification : BaseSpecification<Product>
    {

        public ProductWithFiltersForCountSpecification(ProductSpecParams productParams) 
            : base(x =>
                        (string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search)) &&
                        (!productParams.BrandId.HasValue || x.ProductBrandId == productParams.BrandId) &&
                        (!productParams.TypeId.HasValue || x.ProductTypeId == productParams.TypeId))
        { }

    }
}
