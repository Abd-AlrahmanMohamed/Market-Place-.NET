namespace Handler.MediatorHandler.MediatorQuery.Categories
{
    public class GetCategoryByIdQuery : IRequest<Category>
    {
        public int Id { get; set; }
        public GetCategoryByIdQuery(int id)
        {
            Id = id;
        }
    }
}
