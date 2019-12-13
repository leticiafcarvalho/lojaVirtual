using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
namespace LojaVirtual.Libraries.Email
{
    public class ContatoEmail
    {
        public static NetworkCredential Credentials { get; private set; }
        public static void EnviarContatoPorEmail(Contato contato)
        {
            /*SmtpClient smtp = new SmtpClient("smtp.office365.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("leticia.fcarvalho.job@gmail.com", "senha");
            smtp.EnableSsl = true;*/
            SmtpClient smtp = new SmtpClient
            {
                Port = 587,
                Host = "smtp.office365.com",
                EnableSsl = true,
                //client.Timeout = 10000;
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("naoresponda@primebeneficios.com.br", "Ruta6637")
            };
            string corpoMsg = string.Format("<h2>Contato - LojaVirtual</h2>" +
                "<b>Nome: </b> {0} <br />" +
                "<b>E-mail: </b> {1} <br />" +
                "<b>Texto: </b> {2} <br />" +
                "<br /> E-mail enviado automaticamente do site LojaVirtual.",
                contato.Nome,
                contato.Email,
                contato.Texto
            );
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("naoresponda@primebeneficios.com.br");
            mensagem.To.Add("leticia.fcarvalho.job@gmail.com");
            mensagem.Subject = "Contato - LojaVirtual - E-mail: " + contato.Email;
            mensagem.IsBodyHtml = true;
            smtp.Send(mensagem);
        }
    }
}