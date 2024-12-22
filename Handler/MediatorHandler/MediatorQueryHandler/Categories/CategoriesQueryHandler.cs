namespace Handler.MediatorHandler.MediatorQueryHandler.Categories
{
    public class CategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, IEnumerable<Category>>,
        IRequestHandler<GetCategoryByIdQuery, Category>
    {
        private readonly IUnityOfWork _unityOfWork;

        public CategoriesQueryHandler(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        public async Task<IEnumerable<Category>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            return await _unityOfWork.Repository<Category>().GetAllAsync();
        }

        public async Task<Category> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            return await _unityOfWork.Repository<Category>().GetByidAsync(request.Id);
        }
    }
}
