using System;
using PITONChallenge.Business.Abstract;
using PITONChallenge.DataAccess.Abstract;
using PITONChallenge.Entity.Concrete;
using System.Linq.Expressions;
using PITONChallenge.DataAccess.Concrete;
using AutoMapper;
using PITONChallenge.Business.ViewModels;

namespace PITONChallenge.Business.Concrete
{
	public class UserManager : IUserService
	{

        private readonly IUserDal _userDal;
        private readonly IMapper _mapper;

        public UserManager(IUserDal userDal, IMapper mapper)
        {
            _userDal = userDal;
            _mapper = mapper;
        }

        public string Add(UserVM userVM)
        {
            var user = _mapper.Map<User>(userVM);
            _userDal.Add(user);
            return "Kullanici basariyla eklendi";
        }

        public string Delete(int id)
        {
            var user = _userDal.Get(f => f.Id == id);
            _userDal.Delete(user);
            return "Kullanici basariyla silindi";
        }

        public UserVM Get(Expression<Func<User, bool>> filter)
        {
            var user = _userDal.Get(filter);
            var userVM = _mapper.Map<UserVM>(user);
            return userVM;
        }

        public List<UserVM> GetAll(Expression<Func<User, bool>> filter = null)
        {
            return _userDal.GetAll(filter).Select(u => _mapper.Map<UserVM>(u)).ToList();
        }

        public string Update(UserVM userVM)
        {
            var user = _userDal.Get(u => u.Id == userVM.Id);
            user.UserName = userVM.UserName;
            user.Password = userVM.Password;
            _userDal.Update(user);
            return "Kullanici guncellemesi basariyla yapildi";
        }
}
}

