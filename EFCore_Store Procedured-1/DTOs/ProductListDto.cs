namespace EFCore_Store_Procedured_1.DTOs
{
    public class ProductListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
