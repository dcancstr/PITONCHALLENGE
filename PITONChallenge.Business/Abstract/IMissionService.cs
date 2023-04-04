using System;
using PITONChallenge.Entity.Concrete;
using System.Linq.Expressions;
using PITONChallenge.Business.ViewModels;

namespace PITONChallenge.Business.Abstract
{
	public interface IMissionService
	{
        List<MissionVM> GetAll(Expression<Func<Mission, bool>> filter = null);
        string Add(MissionVM missionVM);
        string Update(MissionVM missionVM);
        string Delete(int id);
        MissionVM Get(Expression<Func<Mission, bool>> filter);
    }
}

