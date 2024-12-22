namespace Handler.Validation.CustomProducts
{
    public class AddCustomProductValidatorHandler : AbstractValidator<AddCustomProductCommand>
    {
        public AddCustomProductValidatorHandler()
        {
            RuleFor(c => c.Title).NotEmpty();
            RuleFor(c => c.Image).NotEmpty();
            RuleFor(c => c.Cost).NotEmpty();
            RuleFor(c => c.UserUploadId).NotNull().NotEmpty();
        }
    }
}
