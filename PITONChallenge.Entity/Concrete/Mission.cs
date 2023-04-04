using System;
using PITONChallenge.Core.Entities;

namespace PITONChallenge.Entity.Concrete
{
	public class Mission : IEntity
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int MissionCategoryId { get; set; }
		public string MissionName { get; set; }
		public DateTime MissionGoalTime { get; set; }

		public MissionCategory MissionCategory { get; set; }
		public User User { get; set; }


	}
}

