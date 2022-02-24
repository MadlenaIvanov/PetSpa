using Microsoft.AspNetCore.Mvc;
using PetSpa.Services.Data;
using PetSpa.Web.ViewModels.Services.ViewModels;
using System.Threading.Tasks;

namespace PetSpa.Web.Controllers
{
    public class ServiceController : BaseController
    {

        private readonly IPetService petService;

        public ServiceController(IPetService petService)
        {
            this.petService = petService;
        }

        public async Task<IActionResult> All()
        {
            var allServices = await this.petService.GetAllServices<AllServicesViewModel>();



            return this.View(allServices);
        }
    }
}
