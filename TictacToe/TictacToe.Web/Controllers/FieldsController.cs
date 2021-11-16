using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TictacToe.Web.Models;

namespace TictacToe.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FieldsController : ControllerBase
    {
        private readonly IFieldRepository fieldRepository;

        public FieldsController(IFieldRepository fieldRepository)
        {
            this.fieldRepository = fieldRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Field>>> GetFields(int boardId) 
        {
            try
            {
              var result = await fieldRepository.GetFieldsByBoard(boardId);

                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Field>>> UpdateField(int fieldId, int boardId, string sign)
        {
            try
            {
                var fieldToUpdate = await fieldRepository.GetField(fieldId, boardId);

                if (fieldToUpdate == null)
                {
                    return NotFound($"Field with Id = {fieldId} not found");
                }

                fieldToUpdate.Sign = Char.Parse(sign);

                return Ok(await fieldRepository.UpdateField(fieldToUpdate));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    $"Error updating field with Id = {fieldId}");
            }

        }

    }
}
