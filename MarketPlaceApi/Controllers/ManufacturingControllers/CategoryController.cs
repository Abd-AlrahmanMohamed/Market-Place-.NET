namespace CQRSWebApi.Controllers.ManfacturingControllers
{
    public class CategoryController : ControllerBase
    {

        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        //[Authorize(Roles = "Admin")]
        [HttpGet(Router.Category.GetCategorytById)]
        public async ValueTask<Category> GetByIdAsync(int id)
        {
            var category = new GetCategoryByIdQuery(id);
            return await _mediator.Send(category);
           
        }
        [HttpGet(Router.Category.GetAllCategories)]
        public async ValueTask<IEnumerable<Category>> GetAllAsync()
        {
            var category = new GetAllCategoriesQuery();
            return (IEnumerable<Category>)await _mediator.Send(category);

        }
        //[Authorize(Roles = "Admin")]
        [HttpPost(Router.Category.AddCategory)]

        public async ValueTask<Category> AddAsync(CategoryDto categoryDto)
        {
            var category = new AddCategoryCommand(categoryDto);
            return await _mediator.Send(category);
        }
        //[Authorize(Roles = "Admin")]
        [HttpPut(Router.Category.UpdateCategory)]

        public async ValueTask<Category> UpdateAsync( CategoryDto categoryDto)
        {

            var category = new UpdateCategoryCommand(categoryDto);
            return await _mediator.Send(category);
        }
        //[Authorize(Roles = "Admin")]
        [HttpDelete(Router.Category.DeleteCategory)]

        public async ValueTask<Category> DeleteAsync(int id)
        {

            var category = new DeleteCategoryCommand(id);
            return await _mediator.Send(category);
        }
    }
}
