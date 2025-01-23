using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.Bussiness.Abstract;
using SignalR.DataAccess.Concrete;
using SignalR.DtoLayer.ProductDto;
using SignalR.Entity.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IProductService _productService;
		private readonly IMapper _mapper;

		public ProductController(IProductService productService, IMapper mapper)
		{
			_productService = productService;
			_mapper = mapper;
		}
		[HttpGet]
		public IActionResult ProductList()
		{
			var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
			return Ok(value);
		}
		[HttpGet("ProductListWithCategory")]
		public IActionResult ProductListWithCategory()
		{
			var context = new SignalRContext();
			var values = context.Products.Include(x => x.Category).Select(y => new ResultProductWithCategory
			{
				Description = y.Description,
				ImageUrl = y.ImageURL,
				Price = y.Price,
				ProductID = y.ProductID,
				ProductName = y.ProductName,
				ProductStatus = y.ProductStatus,
				CategoryName = y.Category.CategoryName
			});
			return Ok(values.ToList());
		}
		[HttpGet("ProductCount")]
		public IActionResult ProductCount()
		{
			return Ok(_productService.TProductCount());
		}
		[HttpGet("ProductCountByDrink")]
		public IActionResult ProductCountByDrink()
		{
			return Ok(_productService.TProductCountByCategoriNameDrink());
		}
		[HttpGet("ProductCountByHamburger")]
		public IActionResult ProductCountByHamburger()
		{
			return Ok(_productService.TProductCountByCategoriNameHamburger());
		}
		[HttpGet("ProductPriceAvg")]
		public IActionResult ProductPriceAvg()
		{
			return Ok(_productService.TProductPriceAvg());
		}
		[HttpGet("ProductNameByMaxPrice")]
		public IActionResult ProductNameByMaxPrice()
		{
			return Ok(_productService.TProductNameByMaxPrice());
		}
		[HttpGet("ProductNameByMinPrice")]
		public IActionResult ProductNameByMinPrice()
		{
			return Ok(_productService.TProductNameByMinPrice());
		}
		[HttpGet("ProductAvgPriceByHamburger")]
		public IActionResult ProductAvgPriceByHamburger()
		{
			return Ok(_productService.TProductAvgPriceByHamburger());
		}

		[HttpPost]
		public IActionResult CreateProduct(CreateProductDto createProductDto)
		{
			_productService.TAdd(new Product()
			{
				Description = createProductDto.Description,
				ImageURL = createProductDto.ImageUrl,
				ProductName = createProductDto.ProductName,
				Price = createProductDto.Price,
				ProductStatus = createProductDto.ProductStatus,
				CategoryId = createProductDto.CategoryID
			});
			return Ok("Ürün Bilgisi Eklendi.");
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteProduct(int id)
		{
			var value = _productService.TGetById(id);
			_productService.TDelete(value);
			return Ok("Ürün Bilgisi Silindi.");
		}
		[HttpGet("{id}")]
		public IActionResult GetProduct(int id)
		{
			var value = _productService.TGetById(id);
			return Ok(value);
		}
		[HttpPut]
		public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
		{
			_productService.TUpdate(new Product()
			{
				ProductID = updateProductDto.ProductID,
				Description = updateProductDto.Description,
				ImageURL = updateProductDto.ImageUrl,
				ProductName = updateProductDto.ProductName,
				Price = updateProductDto.Price,
				ProductStatus = updateProductDto.ProductStatus,
				CategoryId = updateProductDto.CategoryID
			});
			return Ok("Ürün Bilgisi Güncellendi.");
		}
	}
}
