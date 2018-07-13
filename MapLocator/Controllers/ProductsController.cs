using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MapLocator.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MapLocator.Controllers
{
    public class ProductsController : Controller
    {
		private readonly IDutchRepository _repository;
		private readonly ILogger<ProductsController> _logger;

		public ProductsController(IDutchRepository repository, ILogger<ProductsController> logger)
		{
			_logger = logger;
			_repository = repository;
		}

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
