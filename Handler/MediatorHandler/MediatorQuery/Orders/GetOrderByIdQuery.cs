namespace Handler.MediatorHandler.MediatorQuery.Orders
{
    public class GetOrderByIdQuery : IRequest<Order>
    {
        public int Id { get; set; }
        public GetOrderByIdQuery(int id)
        {
            Id = id;
        }
    }
}
