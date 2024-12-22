namespace Handler.MediatorHandler.MediatorCommand.UserUploads
{
    public class DeleteUserUploadCommand : IRequest<UserUpload>
    {
        public int Id { get; set; }
        public DeleteUserUploadCommand(int id)
        {
            Id = id;
        }

    }
}
