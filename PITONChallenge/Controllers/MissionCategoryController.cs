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
    public class MissionCategoryController : ControllerBase
    {
        private readonly IMissionCategoryService _missionCategoryService;

        public MissionCategoryController(IMissionCategoryService missionCategoryService)
        {
            _missionCategoryService = missionCategoryService;
        }
        [HttpGet("GetAll")]
        public IEnumerable<MissionCategoryVM> GetAllMissionCategory()
        {
            return _missionCategoryService.GetAll();
        }
        [HttpPost("Create")]
        public string CreateMissionCategory(MissionCategoryVM missionCategoryVM)
        {
            return _missionCategoryService.Add(missionCategoryVM);

        }
        [HttpPut("Update")]
        public string UpdateMissionCategory(MissionCategoryVM missionCategoryVM)
        {
            return _missionCategoryService.Update(missionCategoryVM);
        }
        [HttpGet("Delete/{id}")]
        public string DeleteMissionCategory(int id)
        {
            return _missionCategoryService.Delete(id);
        }
    }
}
