using System.Net.Mail;
using System.Net;


namespace MLib
{
    public class MLiB
    {
        public static void MailGo(string komy,string tema, string sms)
        {
            SmtpClient Client = new SmtpClient();//создаем клиента для входы в свою почту
            Client.Credentials = new NetworkCredential("адрес@yandex.ru", "пароль");
            Client.Host = "smtp.yandex.ru";
            Client.Port = 587;//порт использующий домен яндекса
            Client.EnableSsl = true;//запрос на проверку надежности входа
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("andreeva.cr1stin@yandex.ru");//от кого 
            mail.To.Add(new MailAddress(komy));//кому отправляется письмо
            mail.Subject =tema;
            mail.IsBodyHtml = true;//для html теней
            mail.Body =sms;//текст сообщения
            Client.Send(mail);
        }
    }
}