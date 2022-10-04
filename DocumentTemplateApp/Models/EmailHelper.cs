using System;
using System.Net;
using System.Net.Mail;

namespace DocumentTemplateApp
{
    /// <summary>
    /// Работа с электронной почтой.
    /// </summary>
    static class EmailHelper
    {
        /// <summary>
        /// Отправляет документ.
        /// </summary>
        /// <param name="from">Отправитель.</param>
        /// <param name="to">Получатель.</param>
        /// <param name="passwordEmail">Пароль.</param>
        /// <param name="nameFile">Имя прикрепляемого файла.</param>
        /// <returns>Удачность отправки сообщения.</returns>
        static public bool Send(string from, string to, string passwordEmail, string nameFile)
        {
            try
            {
                if (string.IsNullOrEmpty(from))
                {
                    throw new ArgumentException("Отправитель не указан");
                }

                if (string.IsNullOrEmpty(to))
                {
                    throw new ArgumentException("Получатель не указан");
                }

                if (string.IsNullOrEmpty(passwordEmail))
                {
                    throw new ArgumentException("Пароль не указан");
                }

                if (string.IsNullOrEmpty(nameFile))
                {
                    throw new ArgumentException("Имя файла не указано");
                }

                var msg = new MailMessage(from, to);
                msg.Subject = "Документ";
                msg.Body = "<h2>Ваш документ</h2>";
                msg.Attachments.Add(new Attachment(nameFile));
                msg.IsBodyHtml = true;

                var smtp = new SmtpClient("smtp.yandex.ru", 587);
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(from, passwordEmail);
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;


                smtp.Send(msg);
            }
            catch
            {
                return false;
            }

            return true;

        }
    }
    
}
