using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrackerLibrary.Models;

namespace MVCUI.Models
{
    public class TeamMVCModel
    {
        [Display(Name = "Team Member List")]
        public List<SelectListItem> TeamMembers { get; set; } = new List<SelectListItem>();

        [StringLength(100, MinimumLength = 2)]
        [Required]
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }

        public List<string> SelectedTeamMembers { get; set; } = new List<string>();
    }
}