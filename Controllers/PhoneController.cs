using Microsoft.AspNetCore.Mvc;
using PhoneReceiverApi.Data;
using PhoneReceiverApi.Models;

namespace PhoneReceiverApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PhoneController(AppDbContext context)
        {
            _context = context;
        }

        public class PhoneRequest
        {
            public string PhoneNumber { get; set; } = string.Empty;
        }

        [HttpPost]
        public async Task<IActionResult> ReceivePhone([FromBody] PhoneRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.PhoneNumber))
            {
                return BadRequest(new { message = "Phone number is required." });
            }

            var record = new PhoneRecord { PhoneNumber = request.PhoneNumber };
            _context.PhoneRecords.Add(record);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Phone number saved successfully!", data = record });
        }
    }
}