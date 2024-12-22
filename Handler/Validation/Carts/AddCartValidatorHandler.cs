using Handler.Dto;

namespace Handler.Validation.Carts
{
    public class AddCartValidatorHandler : AbstractValidator<AddCartCommand>
    {
        public AddCartValidatorHandler()
        {
            RuleFor(c => c.Custom).NotEmpty();
            RuleFor(c => c.Size).NotEmpty();
            RuleFor(c => c.Quantity).NotEmpty();
            RuleFor(c => c.OrderId).NotNull().NotEmpty();
            RuleFor(c => c.ProductId).NotNull().NotEmpty();
        }
    }
}
