namespace Handler.Validation.Carts
{
    public class DeleteCartValidatorHandler : AbstractValidator<DeleteCartCommand>
    {
        public DeleteCartValidatorHandler()
        {
            RuleFor(c => c.Id).NotNull().NotEmpty();
        }
    }
}
