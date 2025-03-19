using IN451_Unit2.Models.ViewModels;
using IN451_Unit2.Services;
using IN451_Unit2.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IN451_Unit2.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService OrderService)
        {
            _orderService = OrderService;
        }

        public IActionResult Index()
        {
            try
            {
                // Fetch data using the service
                var orders = _orderService.GetAllOrders();
                var orderCount = _orderService.GetOrderCount();

                // Create a ViewModel and populate it
                var viewModel = new OrderViewModel
                {
                    Orders = orders,
                    OrderCount = orderCount
                };

                // Pass the ViewModel to the view
                return View(viewModel);
            }
            catch (InvalidOperationException ex)
            {
                // Log or handle the exception as needed
                TempData["ErrorMessage"] = ex.Message;  // Store error message to show on Error page (Dev)
                return RedirectToAction("Error401", "Home");
            }
           
        }
    }
}
