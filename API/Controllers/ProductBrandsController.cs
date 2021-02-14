using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Abstraction;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProductBrandsController : ApiBaseController
    {
        private readonly IGenericRepository<ProductBrand> _brandRepo;

        public ProductBrandsController(IGenericRepository<ProductBrand> brandRepo)
        {
            _brandRepo = brandRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetBrands()
        {
            var results = await _brandRepo.GetAllAsync();
            
            return Ok(results);
        }
    }
}
