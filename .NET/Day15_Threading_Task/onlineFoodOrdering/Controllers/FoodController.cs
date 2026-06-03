using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using onlineFoodOrdering.DTOs;
using onlineFoodOrdering.Models;

namespace onlineFoodOrdering.Controllers
{
    [Route("food")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public FoodController(
            AppDbContext context,
            IWebHostEnvironment enviornment)
        {
            _context = context;
            _environment = enviornment;
        }

        [HttpPost]

        public async Task<IActionResult> AddFood(
            [FromForm] FoodCreateDto dto)
        {
            try
            {
                string fileName = "";

                if(dto.Image != null)
                {
                    fileName = dto.Image.FileName;

                    string folderPath =
                        Path.Combine("wwwroot", "FoodImages" , "foodImages");

                    if (!Directory.Exists(folderPath))
                        Directory.CreateDirectory(folderPath);

                    string filePath =
                        Path.Combine(folderPath, fileName);

                    using var stream =
                        new FileStream(filePath, FileMode.Create);

                    await dto.Image.CopyToAsync(stream);
                }

                var food = new Food
                {
                    Name = dto.Name,
                    Price = dto.Price,
                    Description = dto.Description,
                    Image = fileName
                };

                _context.Foods.Add(food);

                await _context.SaveChangesAsync();

                return Ok(ResultHelper.Success(food));
            }
            catch(Exception ex)
            {
                return BadRequest(
                    ResultHelper.Error<string>(ex.Message));
            }
        }

        [HttpGet("menu")]

        public async Task<IActionResult> Menu()
        {
            try
            {
                var foods = await _context.Foods.ToListAsync();

                return Ok(ResultHelper.Success(foods));
            }
            catch (Exception ex)
            {
                return BadRequest(
                    ResultHelper.Error<string>(ex.Message));
            }
        }
    }
}
