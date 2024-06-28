using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projeto_api_ef.Context;
using projeto_api_ef.Models.Compromissos;
using projeto_api_ef.Utils;

namespace projeto_api_ef.Controllers.Compromissos
{
    [ApiController]
    [Route("[controller]")]
    public class CompromissoController : ControllerBase
    {
    //     public int Id { get; set; }

    // [Required]
    // [MaxLength(100)]
    // public string Titulo { get; set; } = null!;
    // [MaxLength(255)]
    // public string? Descricao { get; set; }
    // public bool JaAconteceu { get; set; } = false;
    // public DateTime Data { get; set; }
    // public string? Link { get; set; }


    // // relacionamentos:
    // public Categoria Categoria { get; set; } = null!;
    // public int CategoriaId { get; set; }
        private readonly ProjetoContext _context;
        public CompromissoController(ProjetoContext context) {
            _context = context;
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> NewCompromisso(int id, CompromissoDto request, CancellationToken ct) {
            var categoria = await _context.Categorias.FirstOrDefaultAsync(c => c.Id == id, ct);


            DateTime data = new();
            if (request.dataString is not null) {
                try { data = Conversao.DataSParaDateTime(request.dataString); }
                catch (Exception e) {
                    return BadRequest(new {
                        error = true,
                        msg = "Erro de conversao de data",
                        errorMsg = e
                    });
                }
            }

            Compromisso novoCompromisso;
            if (request.dataString is null) {
                novoCompromisso = new Compromisso {
                    Titulo = request.titulo,
                    Descricao = request.descricao is null ? null : request.descricao,
                    Link = request.link is null ? null : request.link
                };
            } else {
                novoCompromisso = new Compromisso {
                    Titulo = request.titulo,
                    Descricao = request.descricao is null ? null : request.descricao,
                    Data = data,
                    Link = request.link is null ? null : request.link
                };
            }

            if (novoCompromisso is not null && categoria is not null) {
                categoria.Compromissos.Add(novoCompromisso);
                await _context.SaveChangesAsync(ct);

                return Ok(new {
                    error = false,
                    msg = "Novo compromisso criado com sucesso",
                    idCompromisso = novoCompromisso.Id
                });
            }
            return BadRequest(new {
                error = true,
                msg = "Não foi possivel criar este compromisso"
            });
        }


    }
}