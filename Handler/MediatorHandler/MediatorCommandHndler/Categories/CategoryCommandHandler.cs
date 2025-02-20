namespace Handler.MediatorHandler.MediatorCommandHndler.Categories
{
    public class CategoryCommandHandler : IRequestHandler<AddCategoryCommand, Category>,
        IRequestHandler<UpdateCategoryCommand, Category>, IRequestHandler<DeleteCategoryCommand, Category>
    {

        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;
        public CategoryCommandHandler(IUnityOfWork unityOfWork, IMapper mapper)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
        }
        public async Task<Category> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Category>(request);
            await _unityOfWork.Repository<Category>().AddAsync(category);
            await _unityOfWork.Complete();
            return category;
        }

        public async Task<Category> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var find = await _unityOfWork.Repository<Category>().GetByidAsync(request.Id);
            _mapper.Map(request, find);
            await _unityOfWork.Repository<Category>().UpdateAsync(find);
            await _unityOfWork.Complete();
            return find;
        }

        public async Task<Category> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var find = await _unityOfWork.Repository<Category>().GetByidAsync(request.Id);
            await _unityOfWork.Repository<Category>().DeleteAsync(request.Id);
            await _unityOfWork.Complete();
            return find;
        }
    }
}
