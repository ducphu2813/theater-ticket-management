using Microsoft.AspNetCore.Mvc;
using TheaterTicket.Data;
using TheaterTicket.Model.DTO;
using TheaterTicket.Model.Entities;

namespace TheaterTicket.Controllers;

// localhost:xxxx/api/movie
[Route("api/[controller]")]
[ApiController]
public class MovieController : Controller
{
    
    private readonly ApplicationDbContext _dbContext;

    public MovieController(ApplicationDbContext _dbContext)
    {
        this._dbContext = _dbContext;
    }
    
    [HttpGet]
    public IActionResult GetAll()
    {
        var allMovies = _dbContext.Movies.ToList();
        return Ok(allMovies);
    }
    
    [HttpGet]
    [Route("{id:guid}")]
    public IActionResult GetById(Guid id)
    {
        var movie = _dbContext.Movies.Find(id);
        if (movie == null)
        {
            return NotFound();
        }
        return Ok(movie);
    }
    
    [HttpPost]
    public IActionResult Create(AddMovieDTO dto)
    {
        var newMovie = new Movie
        {
            Name = dto.Name,
            Author = dto.Author,
            Description = dto.Description,
            Director = dto.Director,
            Dub = dto.Dub,
            SubTitle = dto.SubTitle
        };
        _dbContext.Movies.Add(newMovie);
        _dbContext.SaveChanges();
        return Ok(newMovie);
    }
    
    [HttpPut]
    [Route("{id:guid}")]
    public IActionResult Update(Guid id, AddMovieDTO dto)
    {
        var movie = _dbContext.Movies.Find(id);
        if (movie == null)
        {
            return NotFound();
        }

        if (dto.Name != null)
        {
            movie.Name = dto.Name;
        }
        if(dto.Author != null)
        {
            movie.Author = dto.Author;
        }
        if(dto.Description != null)
        {
            movie.Description = dto.Description;
        }
        if(dto.Director != null)
        {
            movie.Director = dto.Director;
        }
        if(dto.Dub != null)
        {
            movie.Dub = dto.Dub;
        }
        if(dto.SubTitle != null)
        {
            movie.SubTitle = dto.SubTitle;
        }
        
        _dbContext.SaveChanges();
        return Ok(movie);
    }
    
}