using System;
using PITONChallenge.Core.Entities;

namespace PITONChallenge.Entity.Concrete
{
	public class User :IEntity
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }

        public IEnumerable<Mission> Mission { get; set; }



    }
}

