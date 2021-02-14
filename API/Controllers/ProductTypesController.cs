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
    public class ProductTypesController : ApiBaseController
    {
        private readonly IGenericRepository<ProductType> _typeRepo;

        public ProductTypesController(IGenericRepository<ProductType> typeRepo)
        {
            _typeRepo = typeRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<ProductType>>> GetProductTypes()
        {
            var result = await _typeRepo.GetAllAsync();

            return Ok(result);
        }
    }
}
