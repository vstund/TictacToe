using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TictacToe.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        private Board board;
        public BoardController()
        {
            board = new Board();
        }
        // GET: api/<BoardController>
        [HttpGet]
        public List<char> Get()
        {
            List<char> oneDimensionArray = new List<char>();
            foreach (var dimension in board.Fields)
            {
                // transform two dimensionl array to one dimension
                oneDimensionArray.Add(dimension);
            }
            return oneDimensionArray;
        }

        // GET api/<BoardController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<BoardController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
          
        }

        // PUT api/<BoardController>/5
        [HttpPut]
        public void Put([FromBody] IPlayer player)
        {
            //board.SetFields(1, player);
            //return;
        }

        // DELETE api/<BoardController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
