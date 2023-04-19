using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Exercicios.Interfaces;
using Exercicios.Model;

namespace Exercicios.Controllers
{
    [Route("[controller]")]
    public class TransacaoController : Controller
    {
        private IClientesServices _clienteService;

        public TransacaoController(IClientesServices clientesServices)
        {
            _clienteService = clientesServices;
        }

        [HttpPost]
        [Route("{idCliente}")]
        public ActionResult AdicionarTransacao([FromBody] Transacao transacao, [FromRoute] int idCliente)
        {
            _clienteService.AdicionarTransacao(transacao, idCliente);
            return Created(Request.Path, transacao);
        }

        [HttpGet]
        [Route("{idCliente}")]
        public ActionResult ListarTransacao([FromRoute] int idCliente)
        {
            return Ok(_clienteService.ListarTransacao(idCliente));
        }
    }
}
