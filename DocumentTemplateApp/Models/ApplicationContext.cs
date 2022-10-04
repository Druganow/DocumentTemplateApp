using System.Data.Entity;

namespace DocumentTemplateApp
{
    /// <summary>
    /// Контекст подключения к базе данных.
    /// </summary>
    public class ApplicationContext : DbContext
    {
        /// <summary>
        /// Таблица операций.
        /// </summary>
        public DbSet<Operation> Operations { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        public ApplicationContext()
            : base("DBConnection")
		{ }
    }
}
