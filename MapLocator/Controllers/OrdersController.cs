﻿using System;
using MapLocator.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MapLocator.Controllers
{
	[Route("api/[Controller]")]
    public class OrdersController : Controller
    {
		private readonly IDutchRepository _repository;
		private readonly ILogger<OrdersController> _logger;

		public OrdersController(IDutchRepository repository, ILogger<OrdersController> logger)
		{
			_repository = repository;
			_logger = logger;
		}

        [HttpGet]
        public IActionResult Get()
        {
            try
			{
				return Ok(_repository.GetAllOrders());
			}
			catch(Exception ex)
			{
				_logger.LogError($"Failed to get orders {ex}");
				return BadRequest("Failed to get orders");
			}
        }
    }
}
