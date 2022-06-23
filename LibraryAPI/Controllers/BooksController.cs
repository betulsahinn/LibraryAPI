using LibraryAPI.Data;
using LibraryAPI.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryAPI.Controllers
{
    [EnableCors]
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _bookRepository.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _bookRepository.GetByIdAsync(id);
            if(data == null)
            {
                return NotFound(id);
            }
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Create (Book book)
        {
            var addedBook = await _bookRepository.CreateAsync(book);
            return Created(string.Empty, addedBook);
        }

        [HttpPut]
        public async Task<IActionResult> Update (Book book)
        {
            var checkBook = await _bookRepository.GetByIdAsync(book.Id);
            if(checkBook == null)
            {
                return NotFound(book.Id);
            }
            await _bookRepository.UpdateAsync(book);
            return NoContent();
        }

         [HttpDelete("{id}")]
         public async Task<IActionResult> Remove(int id)
        {
            var checkBook= await _bookRepository.GetByIdAsync(id);
            if (checkBook == null)
            {
                return NotFound(id);
            }
            await _bookRepository.RemoveAsync(id);
            return NoContent();
        }
    }
}
