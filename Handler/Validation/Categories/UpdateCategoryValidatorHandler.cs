namespace Handler.Validation.Categories
{
    public class UpdateCategoryValidatorHandler : AbstractValidator<UpdateCategoryCommand>
    {
        public UpdateCategoryValidatorHandler()
        {
            RuleFor(c => c.Id).NotNull().NotEmpty();
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.ProductId).NotNull().NotEmpty();
        }
    }
}
