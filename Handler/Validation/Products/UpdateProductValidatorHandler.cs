﻿namespace Handler.Validation.Products
{
    public class UpdateProductValidatorHandler : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductValidatorHandler()
        {
            RuleFor(p => p.Id).NotNull().NotEmpty();
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Description).NotEmpty();
            RuleFor(p => p.Image1).NotEmpty().Must(i => i is IFormFile);
            RuleFor(p => p.Image2).NotEmpty().Must(i => i is IFormFile);
            RuleFor(p => p.Image3).NotEmpty().Must(i => i is IFormFile);
            RuleFor(p => p.Brand).NotEmpty();
            RuleFor(p => p.Color).NotEmpty();
            RuleFor(p => p.Price).NotEmpty();
            RuleFor(p => p.CartId).NotNull().NotEmpty();
            RuleFor(p => p.CategoryId).NotNull().NotEmpty();
        }
    }
}
