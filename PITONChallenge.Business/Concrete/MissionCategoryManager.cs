using System;
using PITONChallenge.DataAccess.Abstract;
using PITONChallenge.Entity.Concrete;
using System.Linq.Expressions;
using PITONChallenge.Business.Abstract;
using AutoMapper;
using PITONChallenge.Business.ViewModels;

namespace PITONChallenge.Business.Concrete
{
	public class MissionCategoryManager : IMissionCategoryService
	{

        private readonly IMissionCategoryDal _missionCategoryDal;
        private readonly IMapper _mapper;

        public MissionCategoryManager(IMissionCategoryDal missionCategoryDal, IMapper mapper)
        {
            _missionCategoryDal = missionCategoryDal;
            _mapper = mapper;
        }

        public string Add(MissionCategoryVM missionCategoryVM)
        {
            var mission = _mapper.Map<MissionCategory>(missionCategoryVM);
            _missionCategoryDal.Add(mission);
            return "Kullanici basariyla eklendi";
        }

        public string Delete(int id)
        {
            var mission = _missionCategoryDal.Get(f => f.Id == id);
            _missionCategoryDal.Delete(mission);
            return "Kullanici basariyla silindi";
        }

        public MissionCategoryVM Get(Expression<Func<MissionCategory, bool>> filter)
        {
            var missionCategory = _missionCategoryDal.Get(filter);
            var missionCategoryVM = _mapper.Map<MissionCategoryVM>(missionCategory);
            return missionCategoryVM;
        }

        public List<MissionCategoryVM> GetAll(Expression<Func<MissionCategory, bool>> filter = null)
        {
            return _missionCategoryDal.GetAll(filter).Select(u => _mapper.Map<MissionCategoryVM>(u)).ToList();
        }

        public string Update(MissionCategoryVM missionCategoryVM)
        {
            var missionCategory = _missionCategoryDal.Get(u => u.Id == missionCategoryVM.Id);
            missionCategory.CategoryName = missionCategory.CategoryName;
            _missionCategoryDal.Update(missionCategory);
            return "Gorev guncellemesi basariyla yapildi";
        }
    }
}

