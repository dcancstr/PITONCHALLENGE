using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PITONChallenge.Business.Abstract;
using PITONChallenge.Business.ViewModels;
using PITONChallenge.Entity.Concrete;

namespace PITONChallenge.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MissionController : ControllerBase
    {
        private readonly IMissionService _missionService;

        public MissionController(IMissionService missionService)
        {
            _missionService = missionService;
        }
        [HttpGet("GetAll")]
        public IEnumerable<MissionVM> GetAllMisson()
        {
            return _missionService.GetAll();
        }
        [HttpPost("Create")]
        public string CreateMission(MissionVM missionVM)
        {
            return _missionService.Add(missionVM);

        }
        [HttpPut("Update")]
        public string UpdateMission(MissionVM missionVM)
        {
            return _missionService.Update(missionVM);
        }
        [HttpGet("Delete/{id}")]
        public string DeleteMission(int id)
        {
            return _missionService.Delete(id);
        }
    }
}
