using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        public int Id { get; set; }
        /// <summary>
        /// List of members in one team
        /// </summary>
        [Display(Name = "Team Member List")]
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// Name of team.
        /// </summary>
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }
    }
}
