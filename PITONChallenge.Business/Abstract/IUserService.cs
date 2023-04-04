using System;
using PITONChallenge.Entity.Concrete;
using System.Linq.Expressions;
using PITONChallenge.Business.ViewModels;

namespace PITONChallenge.Business.Abstract
{
	public interface IUserService
	{
        List<UserVM> GetAll(Expression<Func<User, bool>> filter = null);
        string Add(UserVM userVM);
        string Update(UserVM userVM);
        string Delete(int id);
        UserVM Get(Expression<Func<User, bool>> filter);
    }
}

