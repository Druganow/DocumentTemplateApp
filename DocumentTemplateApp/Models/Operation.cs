namespace DocumentTemplateApp
{
    /// <summary>
    /// Операция.
    /// </summary>
    public class Operation
    {
        /// <summary>
        /// Ид.
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Название операции.
        /// </summary>
        public string OperationName { get; set; }
        
        /// <summary>
        /// Дата операции.
        /// </summary>
        public string OperationDate { get; set; }
    }
}
