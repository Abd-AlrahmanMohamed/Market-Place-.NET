namespace Handler.Validation.Categories
{
    public class AddCategoryValidatorHandler : AbstractValidator<AddCategoryCommand>
    {
        public AddCategoryValidatorHandler()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.ProductId).NotNull().NotEmpty();
        }
    }
}
