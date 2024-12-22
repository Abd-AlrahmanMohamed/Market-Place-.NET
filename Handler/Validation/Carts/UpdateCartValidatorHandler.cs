namespace Handler.Validation.Carts
{
    public class UpdateCartValidatorHandler : AbstractValidator<UpdateCartCommand>
    {
        public UpdateCartValidatorHandler()
        {
            RuleFor(c => c.Id).NotNull().NotEmpty();
            RuleFor(c => c.Custom).NotEmpty();
            RuleFor(c => c.Size).NotEmpty();
            RuleFor(c => c.Quantity).NotEmpty();
            RuleFor(c => c.OrderId).NotNull().NotEmpty();
            RuleFor(c => c.ProductId).NotNull().NotEmpty();
        }
    }
}
