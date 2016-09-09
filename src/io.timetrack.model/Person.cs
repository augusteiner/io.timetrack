
using System.Collections.Generic;
using io.timetrack.common;

namespace io.timetrack.model {

    public class Person : IPerson {

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Project> Projects { get; set; }

        #region EIMI

        IEnumerable<IProject> IPerson.Projects { get { return Projects; } }

        #endregion

    }

}

