namespace Handler.MediatorHandler.MediatorCommandHndler.UserUploads
{
    public class UserUploadCommandHandler : IRequestHandler<AddUserUploadCommand, UserUpload>,
        IRequestHandler<UpdateUserUploadCommand, UserUpload>, IRequestHandler<DeleteUserUploadCommand, UserUpload>
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;
        public UserUploadCommandHandler(IUnityOfWork unityOfWork, IMapper mapper)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
        }
        public async Task<UserUpload> Handle(AddUserUploadCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<UserUpload>(request);
            user.Image = await ImageHandler.ImageConverterAsync(request.Image);
            await _unityOfWork.Repository<UserUpload>().AddAsync(user);
            await _unityOfWork.Complete();
            return user;
        }

        public async Task<UserUpload> Handle(UpdateUserUploadCommand request, CancellationToken cancellationToken)
        {
            var find = await _unityOfWork.Repository<UserUpload>().GetByidAsync(request.Id);
            var user = _mapper.Map(request, find);
            user.Image = await ImageHandler.ImageConverterAsync(request.Image);
            await _unityOfWork.Repository<UserUpload>().UpdateAsync(find);
            await _unityOfWork.Complete();
            return find;
        }

        public async Task<UserUpload> Handle(DeleteUserUploadCommand request, CancellationToken cancellationToken)
        {
            var find = _unityOfWork.Repository<UserUpload>().GetByidAsync(request.Id);
            var delete = await _unityOfWork.Repository<UserUpload>().DeleteAsync(request.Id);
            await _unityOfWork.Complete();
            return delete;
        }
    }
}
