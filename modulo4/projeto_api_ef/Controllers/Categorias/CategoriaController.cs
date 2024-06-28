using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using projeto_api_ef.Context;
using projeto_api_ef.Models.Categorias;

namespace projeto_api_ef.Controllers.Categorias;
[ApiController]
[Route("[controller]")]
public class CategoriaController : ControllerBase
{
    private readonly ProjetoContext _context;
    public CategoriaController(ProjetoContext context) {
        _context = context;
    }


    #region /Categoria => Post
    [HttpPost]
    public async Task<IActionResult> NewCategoria (CategoriaDto request, CancellationToken ct) {
        Categoria novaCategoria = new Categoria {Nome = request.nome};
        try
        {
            await _context.Categorias.AddAsync(novaCategoria, ct);
        }
        catch (Exception e)
        {
            return BadRequest(new {
                error = true,
                msg = "Ocorreu um erro ao salvar o objeto no banco",
                errorMsg = e
            });
        }

        await _context.SaveChangesAsync(ct);


        if (novaCategoria is not null) {
            return Ok(new 
            {
                error = false,
                msg = "Nova categoria criada com sucesso",
                idCategoria = novaCategoria.Id
            });
        }
        return BadRequest(new 
        {
            error = true,
            msg = "Não foi possivel criar a categoria",
        });

    }  
    #endregion


    #region /Categoria => Get
    [HttpGet]
    public async Task<IActionResult> GetCategorias(CancellationToken ct) {
        var todasCategorias = await _context.Categorias
            .Select(categoria => new CategoriaResponseDto(categoria.Id, categoria.Nome, categoria.Compromissos))
            .ToListAsync(ct);


        if (todasCategorias is not null) {
            return Ok(new {
                error = false,
                categorias = todasCategorias
            });
        }
        return BadRequest(new {
            error = true,
            msg = "Não foi possivel buscar todas categorias"
        });
    }
    #endregion
}



// using Microsoft.AspNetCore.Mvc;

// namespace projeto_api_ef.Controllers;

// [ApiController]
// [Route("[controller]")]
// public class WeatherForecastController : ControllerBase
// {
//     private static readonly string[] Summaries = new[]
//     {
//         "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//     };

//     private readonly ILogger<WeatherForecastController> _logger;

//     public WeatherForecastController(ILogger<WeatherForecastController> logger)
//     {
//         _logger = logger;
//     }

//     [HttpGet(Name = "GetWeatherForecast")]
//     public IEnumerable<WeatherForecast> Get()
//     {
//         return Enumerable.Range(1, 5).Select(index => new WeatherForecast
//         {
//             Date = DateTime.Now.AddDays(index),
//             TemperatureC = Random.Shared.Next(-20, 55),
//             Summary = Summaries[Random.Shared.Next(Summaries.Length)]
//         })
//         .ToArray();
//     }
// }
