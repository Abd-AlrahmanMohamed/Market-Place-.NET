namespace Handler.Validation.Orders
{
    public class DeleteOrderValidatorHandler : AbstractValidator<DeleteOrderCommand>
    {
        public DeleteOrderValidatorHandler()
        {
            RuleFor(o => o.Id).NotNull().NotEmpty();
        }
    }
}
