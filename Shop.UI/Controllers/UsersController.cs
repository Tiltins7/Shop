﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.CreateProducts;
using Shop.Application.ProductsAdmin;
using Shop.Application.StockAdmin;
using Shop.Application.UsersAdmin;
using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.UI
{
    [Route("[controller]")]
   [Authorize(Policy = "Admin")]
    public class UsersController : Controller
    {
        private CreateUser _createUser;

        public UsersController(CreateUser createUser)
        {
            _createUser = createUser;
        }

        public async Task<IActionResult> CreateUser([FromBody]CreateUser.Request request)
        {
            await _createUser.Do(request);
            return Ok();
        }
        
    }
}
