using AutoMapper;
using CalenderManagement.DTOs;
using CalenderManagement.Interface;
using CalenderManagement.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalenderManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventAdminController : ControllerBase
    {


        private readonly IAdminForm _adminForm;
        private readonly IMapper _mapper;


        public EventAdminController(IAdminForm adminForm, IMapper mapper)
        {
            _adminForm = adminForm;
            _mapper = mapper;
        }



        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _adminForm.GetAllevent();
            return Ok(result);

        }

        [HttpGet("GetEventById")]
        public async Task<IActionResult> GetById(int id)
        {

            return Ok(await _adminForm.GetById(id));
        }


        [HttpPost("CreateEvent")]
        public async Task<IActionResult> CreateEvent(AdminFormDto adminFormDto )
        {

            var map = _mapper.Map<AdminForm>(adminFormDto);
            _adminForm.Add(map);
            await _adminForm.SaveAll();
            return Ok(map);

        }

        [HttpPut("UpdateEvent")]
        public async Task<IActionResult> UpdateEvent(int id, AdminForm adminForm)
        {
            var Event = await _adminForm.GetById(id);

            //Update employee Detials
            Event.Title = adminForm.Title;
            Event.Descryption = adminForm.Descryption;
            Event.FromDate = adminForm.FromDate;
            Event.ToDate = adminForm.ToDate;
            Event.Join = adminForm.Join;
            Event.JoinMembers = adminForm.JoinMembers;

            //Save Changes
            await _adminForm.SaveChanges();

            return Ok(" event Updated Successfully ");
        }
    }
}
