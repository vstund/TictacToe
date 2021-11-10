using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TictacToe.Web.Models;
// using ContactManager.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TictacToe.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {

        //We inject the DBContext into the controller...
        private ApiContext _context;
        public BoardController(ApiContext context)
        {
            // board = new Board();
            _context = context;
        }
        // GET: api/<BoardController>
        [HttpGet]
        public List<char> Get()
        //public void Get()
        {
            //if (_context.BoardContext.Any())
            //{
            //   // Database has been seeded
            //}
            //else {
            //    _context.BoardContext.Add(new TictacToe.Board());
            //}

            
            List<char> oneDimensionArray = new List<char>();
            foreach (var dimension in _context.BoardContext.First().Fields)
            {
                //transform two dimensionl array to one dimension
                oneDimensionArray.Add(dimension);
            }
            return oneDimensionArray;
            // return;
        }

        // GET api/<BoardController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<BoardController>
        [HttpPost]
        public async Task<IActionResult> Post(int field, int playerId)
        {
            //board.SetFields(field, playerId);
            var tempPlayerObj = new HumanPlayer("Player temporary", Signs.X);

            //_context.BoardContext.First().SetFields(field, tempPlayerObj);
            // var updatedBoard = new Board();
            // updatedBoard.SetFields(field, tempPlayerObj);
            // _context.BoardContext.Update(updatedBoard);

            var tt = await _context.BoardContext.FirstAsync();
            tt.Fields[0, 0] = 'X';

            _context.Entry(tt).State = EntityState.Modified;


            await _context.SaveChangesAsync();
          

            return Ok("success");
        }

        // PUT api/<BoardController>/5
        //[HttpPut]
        //public void Put([FromBody] IPlayer player)
        //{
            
        //}

        // DELETE api/<BoardController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
