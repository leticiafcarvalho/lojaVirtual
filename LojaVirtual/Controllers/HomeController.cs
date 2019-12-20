﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Libraries.Email;
using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text;
using LojaVirtual.Database;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Http;

namespace LojaVirtual.Controllers
{
    public class HomeController : Controller
    {
        private IClienteRepository _repositoryCliente;
        private INewsletterRepository _repositoryINewsletter;
        public HomeController(IClienteRepository repositoryCliente, INewsletterRepository repositoryINewsletter)
        {
            _repositoryCliente = repositoryCliente;
            _repositoryINewsletter = repositoryINewsletter;
        }



        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromForm]NewsletterEmail newsletter)
        {
            if (ModelState.IsValid)
            {
                _repositoryINewsletter.Cadastrar(newsletter);
                TempData["MSG_S"] = "E-mail cadastrado para as promoções!";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        public IActionResult Contato()
        {
            return View();
        }
        public IActionResult ContatoAcao()
        {
            try
            {
                Contato contato = new Contato();
                contato.Nome = HttpContext.Request.Form["nome"];
                contato.Email = HttpContext.Request.Form["email"];
                contato.Texto = HttpContext.Request.Form["texto"];


                var listaMensagens = new List<ValidationResult>();
                var contexto = new ValidationContext(contato);
                bool isValid = Validator.TryValidateObject(contato, contexto, listaMensagens, true);

                if (isValid)
                {
                    ContatoEmail.EnviarContatoPorEmail(contato);

                    ViewData["MSG_S"] = "Mensagem de contato enviado com sucesso!";
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var texto in listaMensagens)
                    {
                        sb.Append(texto.ErrorMessage + "<br />");
                    }

                    ViewData["MSG_E"] = sb.ToString();
                    ViewData["CONTATO"] = contato;
                }


            }
            catch (Exception e)
            {
                ViewData["MSG_E"] = "Opps! Tivemos um erro, tente novamente mais tarde!";

                //TODO - Implementar Log
            }


            return View("Contato");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm] Cliente cliente)
        {
            /*Simulando*/
            if (cliente.Email == "teste@gmail.com" && cliente.Senha == "123456")
            {
                HttpContext.Session.Set("ID", new byte[] { 52 });
                HttpContext.Session.SetString("Email", cliente.Email);
                HttpContext.Session.SetInt32("Idade", 34);

                return new ContentResult() { Content = "Logado!" };
            }
            else
            {
                return new ContentResult() { Content = "Não logado!" };
            }

            // return View();
        }

        [HttpGet]
        public IActionResult Painel()
        {
            /*HttpContext.Session.TryGetValue()
            if ()
            {
                return new ContentResult() { Content = "Acesso concedido: " + UsuarioId };
            }*/
            return new ContentResult() { Content = "Acesso não concedido: " + UsuarioId };
            
        }

        [HttpGet]
        public IActionResult CadastroCliente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroCliente([FromForm] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _repositoryCliente.Cadastrar(cliente);

                TempData["MSG_S"] = "Cliente cadastrado com sucesso!";

                //TODO - Implementar redirecionamentos diferentes
                return RedirectToAction(nameof(CadastroCliente));
            }
            return View();
        }

        public IActionResult CarrinhoCompras()
        {
            return View();
        }
    }
}