
namespace CQRSWebApi.Controllers.ManufacturingControllers
{
    public class CartController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CartController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[Authorize(Roles = "Admin")]
        [HttpGet(Router.Cart.GetCartById)]
        public async Task<Cart> GetByIdAsync(int id)
        {
            var query = new GetCartByIdQuery(id);
            return await _mediator.Send(query);
        }
        [HttpGet(Router.Cart.GetAllCarts)]
        public async Task<IEnumerable<Cart>> GetAllAsync()
        {
            var query = new GetAllCartsQuery();
            return await _mediator.Send(query);

        }
        //[Authorize(Roles = "User")]
        [HttpPost(Router.Cart.AddCart)]

        public async Task<Cart> AddAsync(CartDto cartDto)
        {
            var cart = new AddCartCommand(cartDto);
            return await _mediator.Send(cart);


        }
        //[Authorize(Roles = "User")]
        [HttpPut(Router.Cart.UpdateCart)]

        public async Task<Cart> UpdateAsync(CartDto cartDto)
        {
            var cart = new UpdateCartCommand(cartDto);
            return await _mediator.Send(cart);
        }
        //[Authorize(Roles = "User")]
        [HttpDelete(Router.Cart.DeleteCart)]

        public async Task<Cart> DeleteAsync(int id)
        {
            var cart = new DeleteCartCommand(id);
            return await _mediator.Send(cart);
        }
    }
}
