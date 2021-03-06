using Hospital.RoomsAndEquipment.Model;
using Hospital.RoomsAndEquipment.Repository;
using Hospital.SharedModel.Repository.Base;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HospitalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryItemController : ControllerBase
    {
        private readonly IUnitOfWork _uow;

        public InventoryItemController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        [HttpPost]
        public IActionResult AddInventoryItems(IEnumerable<InventoryItem> inventoryItems)
        {
            var inventoryItemRepo = _uow.GetRepository<IInventoryItemWriteRepository>();
            return Ok(inventoryItemRepo.AddRange(inventoryItems));
        }

    }
}
