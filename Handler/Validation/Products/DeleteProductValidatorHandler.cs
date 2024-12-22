namespace Handler.Validation.Products
{
    public class DeleteProductValidatorHandler : AbstractValidator<DeleteProductrCommand>
    {
        public DeleteProductValidatorHandler()
        {
            RuleFor(p => p.Id).NotNull().NotEmpty();
        }
    }
}
