namespace EFCore_Store_Procedured_1.DTOs
{
    public class CreatedProductDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryId { get; set; }
    }
}
