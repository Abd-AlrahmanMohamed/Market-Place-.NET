namespace Handler.MediatorHandler.MediatorCommand.Carts
{
    public class DeleteCartCommand : IRequest<Cart>
    {
        public int Id { get; set; }
        public DeleteCartCommand(int id)
        {
            Id = id;
        }
    }
}
