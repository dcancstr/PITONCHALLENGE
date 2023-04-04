using System;
using PITONChallenge.DataAccess.Abstract;
using PITONChallenge.Entity.Concrete;
using System.Linq.Expressions;
using PITONChallenge.Business.Abstract;
using AutoMapper;
using PITONChallenge.Business.ViewModels;

namespace PITONChallenge.Business.Concrete
{
	public class MissionManager : IMissionService
	{
        private readonly IMissionDal _missionDal;
        private readonly IMapper _mapper;

        public MissionManager(IMissionDal missionDal, IMapper mapper)
        {
            _missionDal = missionDal;
            _mapper = mapper;
        }

        public string Add(MissionVM missionVM)
        {
            var mission = _mapper.Map<Mission>(missionVM);
            _missionDal.Add(mission);
            return "Kullanici basariyla eklendi";
        }

        public string Delete(int id)
        {
            var mission = _missionDal.Get(f => f.Id == id);
            _missionDal.Delete(mission);
            return "Kullanici basariyla silindi";
        }

        public MissionVM Get(Expression<Func<Mission, bool>> filter)
        {
            var mission = _missionDal.Get(filter);
            var missionVM = _mapper.Map<MissionVM>(mission);
            return missionVM;
        }

        public List<MissionVM> GetAll(Expression<Func<Mission, bool>> filter = null)
        {
            return _missionDal.GetAll(filter).Select(u => _mapper.Map<MissionVM>(u)).ToList();
        }

        public string Update(MissionVM missionVM)
        {
            var mission = _missionDal.Get(u => u.Id == missionVM.Id);
            mission.UserId = missionVM.UserId;
            mission.MissionName = missionVM.MissionName;
            mission.MissionGoalTime = missionVM.MissionGoalTime;
            mission.MissionCategoryId = missionVM.MissionCategoryId;
            _missionDal.Update(mission);
            return "Gorev guncellemesi basariyla yapildi";
        }
    }
}


