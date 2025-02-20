namespace CQRSWebApi.Controllers.ManfacturingControllers
{
    public class CustomProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        //[Authorize(Roles = "Admin")]
        [HttpGet(Router.CustomProduct.GetCustomProductById)]
        public async ValueTask<CustomProduct> GetByIdAsync(int id)
        {
            var custom = new GetCustomProductByIdQuery(id);
            return await _mediator.Send(custom);
        }
        //[Authorize(Roles = "Admin")]
        [HttpGet(Router.CustomProduct.GetAllCustomProducts)]
        public async ValueTask<IEnumerable<CustomProduct>> GetAllAsync()
        {
            var custom = new GetAllCustomProductsQuery();
            return await _mediator.Send(custom);
        }
        //[Authorize(Roles = "User")]
        [HttpPost(Router.CustomProduct.AddCustomProduct)]

        public async ValueTask<CustomProduct> AddAsync(CustomProductDto customProductDto)
        {
            var custom = new AddCustomProductCommand(customProductDto);
            return await _mediator.Send(custom);
        }
        //[Authorize(Roles = "User")]
        [HttpPut(Router.CustomProduct.UpdateCustomProduct)]

        public async ValueTask<CustomProduct> UpdateAsync(CustomProductDto customProductDto)
        {
            var custom = new UpdateCustomProductCommand(customProductDto);
            return await _mediator.Send(custom);

        }
        //[Authorize(Roles = "User")]
        [HttpDelete(Router.CustomProduct.DeleteCustomProduct)]

        public async ValueTask<CustomProduct> DeleteAsync(int id)
        {
            var custom = new DeleteCustomProductCommand(id);
            return await _mediator.Send(custom);
        }

    }

}
