using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Xceed.Words.NET;

namespace DocumentTemplateApp
{
    /// <summary>
    /// Шаблон документа.
    /// </summary>
    class TemplateDocx : Template
    {
        /// <summary>
        /// Начало границы шаблона поля.
        /// </summary>
        private readonly string firstBorder;

        /// <summary>
        /// Конец границы шаблона поля.
        /// </summary>
        private readonly string lastBorder;

        /// <summary>
        /// Файл документа.
        /// </summary>
        private readonly DocX document;

        /// <summary>
        /// Основная часть регулярного выражения.
        /// </summary>
        private const string baseRegex = @"\D*?";

        /// <summary>
        /// Добавляет строки шаблона к строке поля.
        /// </summary>
        /// <param name="baseString">Строка поля.</param>
        /// <returns>Поле с шаблоном.</returns>
        private string AddBorder(string baseString)
        {
            return firstBorder + baseString + lastBorder;
        }

        /// <summary>
        /// Обрезает шаблон поля.
        /// </summary>
        /// <param name="templateString">Шаблон поля.</param>
        /// <returns>Строка поля.</returns>
        private string TrimBorder(string templateString)
        {
            return templateString.Replace(firstBorder, String.Empty)
                .Replace(lastBorder, String.Empty);
        }

        /// <summary>
        /// Возвращает текст документа.
        /// </summary>
        /// <returns>Текст документа.</returns>
        public override string GetText()
        {
            return document.Text;
        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="path">Путь файла шаблона.</param>
        public TemplateDocx(string path, string firstBorder, string lastBorder)
        {
            if (String.IsNullOrEmpty(path))
            {
                throw new ArgumentException("Пустая строка пути файла.");
            }

            if (String.IsNullOrEmpty(firstBorder))
            {
                throw new ArgumentException("Пустая строка начала границы шаблона.");
            }

            if (String.IsNullOrEmpty(lastBorder))
            {
                throw new ArgumentException("Пустая строка конца границы шаблона.");
            }

            document = DocX.Load(path);
            this.firstBorder = firstBorder;
            this.lastBorder = lastBorder;
        }

        /// <summary>
        /// Формирует лист полей шаблона.
        /// </summary>
        /// <returns>Список полей шаблона.</returns>
        public override List<string> GetFieldsTemplate()
        {
            var listBorderField = document.FindUniqueByPattern(AddBorder(baseRegex), RegexOptions.Multiline);
            var listField = new List<string>();

            foreach (var field in listBorderField)
            {
                listField.Add(TrimBorder(field));
            }

            return listField;
        }

        /// <summary>
        /// Заменяет шаблоны полей на значения из словаря.
        /// </summary>
        /// <param name="fieldsTemplace">Словарь "поле-значение".</param>
        public override void ReplaceText(Dictionary<string, string> fieldsTemplace)
        {
            if (fieldsTemplace == null)
            {
                throw new ArgumentException("Пустой словарь");
            }

            foreach (var x in fieldsTemplace)
            {
                document.ReplaceText(AddBorder(x.Key), x.Value);
            }
        }

        /// <summary>
        /// Сохраняет текущий документ.
        /// </summary>
        /// <param name="path">Путь будущего файла.</param>
        public override void SaveFile(string path)
        {
            if (String.IsNullOrEmpty(path))
            {
                throw new ArgumentException("Пустая строка пути файла.");
            }

            try
            {
                document.SaveAs(path);
            }
            catch
            { }
        }
    }
}
