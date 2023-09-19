using AutoMapper;
using EFCore_Store_Procedured_1.DAL;
using EFCore_Store_Procedured_1.DTOs;
using EFCore_Store_Procedured_1.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Store_Procedured_1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProdcutsController : ControllerBase
    {
        private readonly IMapper _mapper;

        public ProdcutsController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllWithCategoryName()
        {
            using (var _context = new MSSQLDB())
            {
                var products = await _context.ProductListDtos.FromSqlRaw("exec  sp_get_product_full").ToListAsync();
                return Ok(products);
            }
        }
        [HttpGet]
        [Route("{categoryId}")]
        public async Task<IActionResult> GetByCategoryId([FromRoute] int categoryId)
        {
            using (var _context = new MSSQLDB())
            {
                //parameterleri işlerde FromSqlInterpolated() metodu kullanmak gerekir.
                var products = await _context.ProductListDtos.FromSqlInterpolated($"exec sp_get_product_full_parameters {categoryId}").ToListAsync();
                return Ok(products);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreatedProductDto createdProductDto)
        {
            using (var _context = new MSSQLDB())
            {
                var newProdcutIdParameter = new SqlParameter("@newId", System.Data.SqlDbType.Int);
                newProdcutIdParameter.Direction = System.Data.ParameterDirection.Output;
                Product product = _mapper.Map<Product>(createdProductDto);

                await _context.Database.
                    ExecuteSqlInterpolatedAsync($"exec st_insert_product {product.Name},{product.UnitPrice},{product.CategoryId},{product.Description},{newProdcutIdParameter} out");
                var newProductId = newProdcutIdParameter.Value;
                return Ok(createdProductDto);
            }
        }


    }
}
