using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteParaDesenvolvedor.Core;
using TesteParaDesenvolvedor.Model;

namespace TesteParaDesenvolvedor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PalavraController : ControllerBase
    {
        private readonly IPalavra core;

        public PalavraController(IPalavra palavraCore)
        {
            core = palavraCore;
        }

        [HttpPost("ContadorMovimentacao")]
        public IActionResult ContadorMovimentacao(Palavras palavras)
        {
            var result = core.CalcularMovimentacaoPalavra(palavras);

            return Ok(new { Movimentacao = result, PalavraCalculada = palavras.Palavra2 });
        }
    }
}