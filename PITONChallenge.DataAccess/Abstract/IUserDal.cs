using System;
using PITONChallenge.Core.DataAccess;
using PITONChallenge.Entity.Concrete;

namespace PITONChallenge.DataAccess.Abstract
{
	public interface IUserDal : IEntityRepository<User>
    {
	}
}

