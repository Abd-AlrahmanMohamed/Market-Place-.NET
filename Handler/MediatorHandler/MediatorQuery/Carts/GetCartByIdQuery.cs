namespace Handler.MediatorHandler.MediatorQuery.Carts
{
    public class GetCartByIdQuery : IRequest<Cart>
    {
        public int Id { get; set; }

        public GetCartByIdQuery(int id)
        {
            Id = id;
        }
    }
}
