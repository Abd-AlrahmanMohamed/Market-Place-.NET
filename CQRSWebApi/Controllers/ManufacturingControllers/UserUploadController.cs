namespace CQRSWebApi.Controllers.ManfacturingControllers
{
    public class UserUploadController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserUploadController(IMediator mediator)
        {
            _mediator = mediator;
        }
        //[Authorize(Roles = "Admin")]
        [HttpGet(Router.UserUpload.GetUserUploadById)]
        public async ValueTask<UserUpload> GetByIdAsync(int id)
        {
            var order = new GetUserUploadByIdQuery(id);
            return await _mediator.Send(order);
        }
        //[Authorize(Roles = "Admin")]
        [HttpGet(Router.UserUpload.GetAllUserUploads)]
        public async ValueTask<IEnumerable<UserUpload>> GetAllAsync()
        {
            var order = new GetAllUserUploadsQuery();
            return await _mediator.Send(order);
        }

        [HttpPost(Router.UserUpload.AddUserUpload)]

        public async ValueTask<UserUpload> AddAsync(UserUploadDto userUploadDto)
        {
            var order = new AddUserUploadCommand(userUploadDto);
            return await _mediator.Send(order);
        }

        [HttpPut(Router.UserUpload.UpdateUserUpload)]

        public async ValueTask<UserUpload> UpdateAsync(UserUploadDto userUploadDto)
        {
            var order = new UpdateUserUploadCommand(userUploadDto);
            return await _mediator.Send(order);
        }

        [HttpDelete(Router.UserUpload.DeleteUserUpload)]

        public async ValueTask<UserUpload> DeleteAsync(int id)
        {
            var order = new DeleteUserUploadCommand(id);
            return await _mediator.Send(order);
        }
    }
}
