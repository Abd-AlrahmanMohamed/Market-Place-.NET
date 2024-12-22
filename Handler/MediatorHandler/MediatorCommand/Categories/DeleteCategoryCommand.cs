namespace Handler.MediatorHandler.MediatorCommand.Categories
{
    public class DeleteCategoryCommand : IRequest<Category>
    {
        public int Id { get; set; }
        public DeleteCategoryCommand(int id)
        {
            Id = id;
        }
    }
}
