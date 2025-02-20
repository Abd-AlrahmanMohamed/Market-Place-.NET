namespace Handler.Validation.Categories
{
    public class DeleteCategoryValidatorHandler : AbstractValidator<DeleteCategoryCommand>
    {
        public DeleteCategoryValidatorHandler()
        {
            RuleFor(c => c.Id).NotNull().NotEmpty();
        }
    }
}
