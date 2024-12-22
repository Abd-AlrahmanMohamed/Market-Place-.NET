namespace Handler.MediatorHandler.MediatorQuery.UserUploads
{
    public class GetUserUploadByIdQuery : IRequest<UserUpload>
    {
        public int Id { get; set; }
        public GetUserUploadByIdQuery(int id)
        {
            Id = id;
        }
    }
}
