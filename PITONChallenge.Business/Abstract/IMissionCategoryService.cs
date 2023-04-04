using System;
using PITONChallenge.Entity.Concrete;
using System.Linq.Expressions;
using PITONChallenge.Business.ViewModels;

namespace PITONChallenge.Business.Abstract
{
	public interface IMissionCategoryService
	{
        List<MissionCategoryVM> GetAll(Expression<Func<MissionCategory, bool>> filter = null);
        string Add(MissionCategoryVM missionCategoryVM);
        string Update(MissionCategoryVM missionCategoryVM);
        string Delete(int id);
        MissionCategoryVM Get(Expression<Func<MissionCategory, bool>> filter);
    }
}

