namespace Handler.MediatorHandler.MediatorCommand.Products
{
    public class DeleteProductrCommand : IRequest<Product>
    {
        public int Id { get; set; }
        public DeleteProductrCommand(int id)
        {
            Id = id;
        }
    }
}
