namespace Handler.MediatorHandler.MediatorQueryHandler.UserUploads
{
    public class UserUploadsQueryHandler : IRequestHandler<GetAllUserUploadsQuery, IEnumerable<UserUpload>>,
        IRequestHandler<GetUserUploadByIdQuery, UserUpload>
    {
        private readonly IUnityOfWork _unityOfWork;
        public UserUploadsQueryHandler(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }
        public async Task<IEnumerable<UserUpload>> Handle(GetAllUserUploadsQuery request, CancellationToken cancellationToken)
        {
            return await _unityOfWork.Repository<UserUpload>().GetAllAsync();
        }

        public async Task<UserUpload> Handle(GetUserUploadByIdQuery request, CancellationToken cancellationToken)
        {
            return await _unityOfWork.Repository<UserUpload>().GetByidAsync(request.Id);
        }
    }
}
