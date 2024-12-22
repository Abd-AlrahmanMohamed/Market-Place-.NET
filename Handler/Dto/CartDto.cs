namespace Handler.Dto
{
    public class CartDto
    {
        public int Id { get; set; }
        public string Custom { get; set; } = string.Empty;
        public int Size { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
    }
}
