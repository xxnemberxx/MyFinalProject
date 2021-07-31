using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntıtyFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // c# Attribute -- Java Annotation
    public class ProductsController : ControllerBase
    {

        /// <summary>
        /// Loosely Coupled
        /// naming convention 
        /// IOC Cotainer --> Inversion Of Control
        /// </summary>
        private IProductService _productManager;
        public ProductsController(IProductService productManager)
        {
            _productManager = productManager;
        }
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            // Swagger
            // Dependency chain --
            var result =_productManager.GetAll();
            if(result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
