using Chapter16._1.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Chapter16._1.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase

    {
        private readonly LivroRepository livroRepository;
        private LivroRepository LivroRepository;

        public LivroController(LivroRepository livroRepository)
        {
            LivroRepository = livroRepository;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(LivroRepository.Listar());
            {
                try
                {
                    return Ok(LivroRepository.Listar());
                }
                catch (Exception e)
                {
                throw new Exception(e.Message);
                }
            }
        }
    }
}