using System;
using PITONChallenge.Core.Entities;

namespace PITONChallenge.Entity.Concrete
{
	public class MissionCategory : IEntity
	{
		public int Id { get; set; }
		public string CategoryName { get; set; }

        public IEnumerable<Mission> Mission { get; set; }
    }
}

