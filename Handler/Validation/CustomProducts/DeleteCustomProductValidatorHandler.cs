namespace Handler.Validation.CustomProducts
{
    public class DeleteCustomProductValidatorHandler : AbstractValidator<DeleteCustomProductCommand>
    {
        public DeleteCustomProductValidatorHandler()
        {
            RuleFor(c => c.Id).NotNull().NotEmpty();
        }
    }
}
