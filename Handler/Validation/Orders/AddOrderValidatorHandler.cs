namespace Handler.Validation.Orders
{
    public class AddOrderValidatorHandler : AbstractValidator<AddOrderCommand>
    {
        public AddOrderValidatorHandler()
        {
            RuleFor(o => o.Name).NotEmpty();
            RuleFor(o => o.Address).NotEmpty();
            RuleFor(o => o.City).NotEmpty();
            RuleFor(o => o.ZipCode).NotNull().NotEmpty();
            RuleFor(o => o.Contact).NotNull().NotEmpty();
            RuleFor(o => o.CartId).NotNull().NotEmpty();
        }
    }
}
