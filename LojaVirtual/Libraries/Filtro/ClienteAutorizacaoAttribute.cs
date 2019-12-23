﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace LojaVirtual.Libraries.Filtro
{
    /*tipos de filtros*/
    /*Autorização
     * Recurso
     * Ação
     * Exceção
     * Resultado
     */
    public class ClienteAutorizacaoAttribute : Attribute, IAuthorizationFilter
    {
        LoginCliente _loginCliente;
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _loginCliente = (LoginCliente)context.HttpContext.RequestServices.GetService(typeof(LoginCliente));
            Cliente cliente = _loginCliente.GetCliente();
            if (cliente == null)
            {
                context.Result =  new ContentResult() { Content = "Acesso não concedido! " };
            }





            /*if (cliente != null)
            {
                return new ContentResult() { Content = "Acesso concedido! Usuário: " + cliente.Id + " Email: " + cliente.Email };
            }
            else
            {
                return new ContentResult() { Content = "Acesso não concedido! " };
            }*/
        }
    }
}
