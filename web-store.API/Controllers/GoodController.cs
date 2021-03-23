using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nelibur.ObjectMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_store.API.Model;
using web_store.BL.Services;

namespace web_store.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodController : ControllerBase
    {
        private readonly IGoodService goodService;

        public GoodController(IGoodService goodService)
        {
            this.goodService = goodService;
        }

        /// <summary>
        /// End-point for add new good
        /// </summary>
        /// <param name="good"></param>
        /// <returns></returns>
        [Route("AddGood")]
        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] Good good)
        {
            if (good != null)
            {
                TinyMapper.Bind<Good, web_store.BL.Model.Good>();
                var newGood = TinyMapper.Map<web_store.BL.Model.Good>(good);

                await goodService.AddGood(newGood);
                return Ok(good);
            } 
            else
            {
                return BadRequest();
            }            
        }


    }
}
