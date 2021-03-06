﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatanLayoutGenerator.Services;
using CatanLayoutGenerator.Services.Models;
using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CatanLayoutGenerator.Controllers {
    [Route("api/[controller]")]
    public class BoardLayoutsController : Controller {
        private BoardLayoutService _boardLayoutService;

        public BoardLayoutsController(BoardLayoutService boardLayoutService) {
            _boardLayoutService = boardLayoutService;
        }

        // GET: api/values
        [HttpGet]
        public ICollection<BoardLayoutDTO> Get() {
            return _boardLayoutService.GetBoardLayouts().ToList();
        }

        /*// GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id) {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value) {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value) {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }*/
    }
}
