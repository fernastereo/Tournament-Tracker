using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary {

    /// <summary>
    /// Represents one person
    /// </summary>
    public class PersonModel {

        /// <summary>
        /// The first name of the person.
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        /// The last name of the person.
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        /// The primary email address of the person.
        /// </summary>
        public string emailAddress { get; set; }

        /// <summary>
        /// The primary cellphone number of the person.
        /// </summary>
        public string cellphoneNumber { get; set; }

    }
}
