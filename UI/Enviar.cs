using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;



namespace PadraoDeProjetoEmCamadas
{
    class Enviar
    {
            public void Envio(string Nome, string Telefone, string Endereco, string Descrição)
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("primeiroperiodopic@gmail.com");
                mail.To.Add(new MailAddress("Joao.raymundo@alunos.unis.edu.br"));

                mail.Subject = Nome;

                mail.Body = "Nome: " + Nome + ";" +
                            ", Telefone : " + Telefone + ";" +
                            ", Endereco: " + Endereco + ";" +
                            ", Descricao: " + Descrição + ";" ;
                mail.IsBodyHtml = true;


                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

                smtp.Credentials = new System.Net.NetworkCredential("primeiroperiodopic@gmail.com", "primeiropic@2020");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                MessageBox.Show("Usuario inserido com sucesso");
            }

        
    }
}