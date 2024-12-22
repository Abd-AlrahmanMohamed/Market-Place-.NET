namespace Handler.MediatorHandler.MediatorCommand.CustomProducts
{
    public class DeleteCustomProductCommand : IRequest<CustomProduct>
    {
        public int Id { get; set; }
        
        public DeleteCustomProductCommand(int id)
        {
            Id = id;
        }
    }
}
