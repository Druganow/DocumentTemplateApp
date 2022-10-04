using System;

namespace DocumentTemplateApp
{
    /// <summary>
    /// Логгер.
    /// </summary>
    static public class Logger
    {
        /// <summary>
        /// Создает лог операции.
        /// </summary>
        /// <param name="text">Название операции.</param>
        static public void Record(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                throw new ArgumentException("Пустая строка");
            }

            using (var db = new ApplicationContext())
            {
                var operation = new Operation()
                {
                    OperationDate = DateTime.Now.ToString(),
                    OperationName = text
                };

                db.Operations.Add(operation);
                db.SaveChanges();
            }
        }
    }
}
