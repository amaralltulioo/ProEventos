﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento =  new Evento[]{
            new  Evento() {
                EventoId = 1,
                Tema = "Angular 11 e Donet 5",
                Local = "Belo Horizonte",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
            },

            new  Evento() {
                EventoId = 2,
                Tema = "Angular 15 e Donet 6",
                Local = "São Paulo",
                Lote = "1º Lote",
                QtdPessoas = 987,
                DataEvento = DateTime.Now.AddDays(15).ToString("dd/MM/yyyy")
            }
        };


        [HttpGet]
        public IEnumerable<Evento> Get(){
            return _evento;
        }

        [HttpGet("{Id}")]
        public IEnumerable<Evento> GetById(int id){
            return _evento.Where(Evento => Evento.EventoId == id);
        }
        
    }
}
