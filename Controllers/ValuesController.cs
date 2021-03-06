﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProAgil.WebAPI.Data;
using ProAgil.WebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAgil.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public readonly DataContext Context;

        public readonly DataContextTeste ContextTeste;

        public ValuesController(DataContext context, DataContextTeste contextTeste)
        {
            Context = context;
            ContextTeste = contextTeste;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await Context.Eventos.ToListAsync());
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou.");
            }
        }

        // GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<Evento>> Get()
        //{
        //    return Context.Eventos.ToList();

        //    //return new Evento[]
        //    //{
        //    //    new Evento() {
        //    //        EventoId = 1,
        //    //        Tema = "Angular e .NET Core",
        //    //        Local = "Belo Horizonte",
        //    //        Lote = "1º Lote",
        //    //        QtdPessoas = 250,
        //    //        DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
        //    //    },
        //    //    new Evento() {
        //    //        EventoId = 2,
        //    //        Tema = "Angular e Suas Novidades",
        //    //        Local = "São Paulo",
        //    //        Lote = "2º Lote",
        //    //        QtdPessoas = 350,
        //    //        DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
        //    //    }
        //    //};
        //}

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok (await Context.Eventos.FirstOrDefaultAsync(x => x.EventoId == id));

            //return new Evento[]
            //{
            //    new Evento() {
            //        EventoId = 1,
            //        Tema = "Angular e .NET Core",
            //        //Local = "Belo Horizonte",
            //        Lote = "1º Lote",
            //        QtdPessoas = 250,
            //        DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
            //    },
            //    new Evento() {
            //        EventoId = 2,
            //        Tema = "Angular e Suas Novidades",
            //        //Local = "São Paulo",
            //        Lote = "2º Lote",
            //        QtdPessoas = 350,
            //        DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
            //    }
            //}.FirstOrDefault(x => x.EventoId == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
