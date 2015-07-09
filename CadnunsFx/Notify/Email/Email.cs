using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CadnunsFx.Notify.Email
{
    public class Email
    {
        /* 
         * ------- Email details Teste---------------
Webmail address	http://webmail.hostinger.com.br
Login Username	tiago.nascimento@cadnunsdimir.esy.es
Password	****** (senha padrão)
POP3/IMAP Host	mx1.hostinger.com.br
POP3 Port	110
POP3 Port (secured)	Upgrade 
IMAP Port	Upgrade 
IMAP Port (secured)	Upgrade 
SMTP Host	mx1.hostinger.com.br
SMTP Ports	Use Webmail  client or Upgrade 
SMTP Ports (secured)	Use Webmail  client or Upgrade 
         * 
         */

        /*
         *
         * Servidor (SMTP) de Mail - Requer TLS

Servidor: smtp.mail.yahoo.com.br
Porta: 465 ou 587
Requer SSL: Sim
Requer autenticação: Sim
         * 
         */

        public string nomeRemetente { get; set; }
        private string _host = "smtp.mail.yahoo.com.br";
        private string _username = "tiago.cadnuns@yahoo.com.br";
        private string _password = "nfbqt77j";
        private int _port = 587;

        
        public Email(string NomeRemetente)
        {
            this.nomeRemetente = NomeRemetente;
        }

        public void SendEmail(string EmailDestino, string msg)
        {
            SmtpClient client = new SmtpClient(_host, _port);
            //SmtpClient client = new SmtpClient(_host, 110);

            //client.Host = "mx1.hostinger.com.br";
            client.EnableSsl = true;

            client.Credentials = new NetworkCredential(_username, _password);

            MailMessage mensagem = new MailMessage(
                new MailAddress(_username, this.nomeRemetente),
                new MailAddress(EmailDestino));

            mensagem.Subject = "NOtificar";
            mensagem.Body = msg;
            mensagem.IsBodyHtml = false;
            mensagem.Priority = MailPriority.High;
            try
            {                
                client.Send(mensagem);
            }
            catch(Exception e)
            {
                //throw new Exception("Não foi possível enviar o Email", e);
                throw e;
            }
        }

    }
}
