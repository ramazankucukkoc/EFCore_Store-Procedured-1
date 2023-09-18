namespace EFCore_Store_Procedured_1.Entities
{
    public class Product:Entity
    {
        public decimal UnitPrice { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
