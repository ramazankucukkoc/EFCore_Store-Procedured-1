using AutoMapper;
using EFCore_Store_Procedured_1.DAL;
using EFCore_Store_Procedured_1.DTOs;
using EFCore_Store_Procedured_1.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Store_Procedured_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdcutsController : ControllerBase
    {
        private readonly IMapper _mapper;

        public ProdcutsController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            using (var _context = new MSSQLDB())
            {
                List<Product> products = await _context.Products.FromSqlRaw("exec  sp_get_proudtcs").ToListAsync();
                List<ProductListDto> list = _mapper.Map<List<ProductListDto>>(products);
                
                return Ok(list);
            }

        }


    }
}
