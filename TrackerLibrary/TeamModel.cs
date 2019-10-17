using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary {
    public class TeamModel {
        public List<PersonModel> teamMembers { get; set; } = new List<PersonModel>(); //this is for initialize the property
        public string teamName { get; set; }
    }
}
