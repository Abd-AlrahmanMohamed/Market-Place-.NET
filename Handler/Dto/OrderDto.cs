namespace Handler.Dto
{
    public class OrderDto
    {
        public int Id { get; set; }
        [MaxLength(255), MinLength(5)]
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public int ZipCode { get; set; }
        [Required]
        public int Contact { get; set; }
        public int CartId { get; set; }
        

    }
}
