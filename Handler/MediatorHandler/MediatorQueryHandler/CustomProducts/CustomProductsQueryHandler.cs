namespace Handler.MediatorHandler.MediatorQueryHandler.CustomProducts
{
    public class CustomProductsQueryHandler : IRequestHandler<GetAllCustomProductsQuery, IEnumerable<CustomProduct>>,
        IRequestHandler<GetCustomProductByIdQuery, CustomProduct>
    {
        private readonly IUnityOfWork _unityOfWork;
        public CustomProductsQueryHandler(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }
        public async Task<IEnumerable<CustomProduct>> Handle(GetAllCustomProductsQuery request, CancellationToken cancellationToken)
        {
            return await _unityOfWork.Repository<CustomProduct>().GetAllAsync();
        }

        public async Task<CustomProduct> Handle(GetCustomProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await _unityOfWork.Repository<CustomProduct>().GetByidAsync(request.Id);
        }
    }
}
