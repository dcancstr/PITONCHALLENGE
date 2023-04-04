using System;
namespace PITONChallenge.Business.ViewModels
{
	public class MissionVM
	{
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MissionCategoryId { get; set; }
        public string MissionName { get; set; }
        public DateTime MissionGoalTime { get; set; }
    }
}

