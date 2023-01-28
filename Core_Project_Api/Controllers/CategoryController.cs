using Core_Project_Api.DAL.ApiContext;
using Core_Project_Api.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Project_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet] 
        public IActionResult CategoryList()
        {
            using var context = new Context();
            return Ok(context.Categories.ToList());
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            using var context = new Context();
            var values = context.Categories.Find(id);
            if (values == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(values);
            }
        }
        [HttpPost]
        public  IActionResult AddCategory(Category category)
        {
            using var context = new Context();
            context.Add(category);
            context.SaveChanges();
            return Created("", category);
        }
        [HttpDelete]
        public IActionResult CategoryDelete(int id) 
        {
        
            using var context = new Context();
            var values = context.Categories.Find(id);

            if (values == null)
            {
                return NotFound();
            }
            else
            {
                context.Remove(values);
                context.SaveChanges();
                return NoContent();
            }
        }
        [HttpPut]
        public IActionResult UpdateCategory(Category category)
        {
            using var context = new Context();
            var values = context.Find<Category>(category.CategoryID);
            if (values == null )
            {
                return NotFound();
            }
            else
            {
                values.CategoryName = category.CategoryName;
                context.Update(values);
                context.SaveChanges();
                return NoContent();
            }
        }

    }
}
