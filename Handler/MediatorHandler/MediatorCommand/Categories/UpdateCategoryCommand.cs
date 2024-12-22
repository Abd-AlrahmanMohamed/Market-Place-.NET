namespace Handler.MediatorHandler.MediatorCommand.Categories
{
    public class UpdateCategoryCommand : IRequest<Category>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ProductId { get; set; }

        public UpdateCategoryCommand(CategoryDto categoryDto)
        {
            Id = categoryDto.Id;
            Name = categoryDto.Name;
            Description = categoryDto.Description;
            ProductId = categoryDto.ProductId;
        }
    }
}
