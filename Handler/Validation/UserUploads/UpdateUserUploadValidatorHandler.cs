namespace Handler.Validation.UserUploads
{
    public class UpdateUserUploadValidatorHandler : AbstractValidator<UpdateUserUploadCommand>
    {
        public UpdateUserUploadValidatorHandler()
        {
            RuleFor(o => o.Id).NotNull().NotEmpty();
            RuleFor(o => o.Image).NotEmpty().Must(i => i is IFormFile);
            RuleFor(o => o.CustomProductId).NotNull().NotEmpty();
        }
    }
}
