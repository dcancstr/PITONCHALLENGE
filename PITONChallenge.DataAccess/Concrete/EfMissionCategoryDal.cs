using System;
using PITONChallenge.Core.DataAccess.EntityFramework;
using PITONChallenge.DataAccess.Abstract;
using PITONChallenge.Entity.Concrete;

namespace PITONChallenge.DataAccess.Concrete
{
	public class EfMissionCategoryDal : EfEntityRepositoryBase<MissionCategory, Context>, IMissionCategoryDal
    {
		
	}
}

