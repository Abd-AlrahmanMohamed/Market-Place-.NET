namespace Handler.Validation.CustomProducts
{
    public class UpdateCustomProductValidatorHandler : AbstractValidator<UpdateCustomProductCommand>
    {
        public UpdateCustomProductValidatorHandler()
        {
            RuleFor(c => c.Id).NotNull();
            RuleFor(c => c.Title).NotEmpty();
            RuleFor(c => c.Image).NotEmpty();
            RuleFor(c => c.Cost).NotEmpty();
            RuleFor(c => c.UserUploadId).NotNull();
        }
    }
}
