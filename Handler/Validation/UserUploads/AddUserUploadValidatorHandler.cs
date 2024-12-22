namespace Handler.Validation.UserUploads
{
    public class AddUserUploadValidatorHandler : AbstractValidator<AddUserUploadCommand>
    {
        public AddUserUploadValidatorHandler()
        {
            RuleFor(o => o.Image).NotEmpty().Must(i => i is IFormFile);
            RuleFor(o => o.CustomProductId).NotNull().NotEmpty();
        }
    }
}
