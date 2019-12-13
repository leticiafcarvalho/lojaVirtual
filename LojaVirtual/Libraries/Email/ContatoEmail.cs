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
        public static void EnviarContatoPorEmail(Contato contato)
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("leticia.fcarvalho.job@gmail.com", "32452042");
            smtp.EnableSsl = true;

            string corpoMsg = string.Format("<h2>Contato - LojaVirtual</h2>" +
                "<br>Nome: </b> {0} <br />" +
                "<b>Email: </b> {1} <br />" +
                "<b>Texto: </b> {2} <br />" +
                "<br /> <b>E-mail enviado automaticamente da LojaVirtual.</b>", 
                contato.Nome,
                contato.Email, 
                contato.Texto
            );    

            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("leticia.fcarvalho.job@gmail.com");
            mensagem.To.Add("leticia.fcarvalho.job@gmail.com");
            mensagem.Subject = "Contato - LojaVirtual - E-mail: " + contato.Email;
            mensagem.Body = "Texto: " + contato.Texto;
            mensagem.IsBodyHtml = true;

            smtp.Send(mensagem);
 
        }
    }
}
