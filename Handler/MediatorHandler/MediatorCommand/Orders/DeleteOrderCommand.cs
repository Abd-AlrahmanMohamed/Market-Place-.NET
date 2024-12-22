namespace Handler.MediatorHandler.MediatorCommand.Orders
{
    public class DeleteOrderCommand : IRequest<Order>
    {
        public int Id { get; set; }
        public DeleteOrderCommand(int id )
        {
            Id = id;
        }
    }
}
