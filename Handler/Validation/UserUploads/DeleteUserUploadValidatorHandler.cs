namespace Handler.Validation.UserUploads
{
    public class DeleteUserUploadValidatorHandler : AbstractValidator<DeleteUserUploadCommand>
    {
        public DeleteUserUploadValidatorHandler()
        {
            RuleFor(o => o.Id).NotNull().NotEmpty();
        }
    }
}
