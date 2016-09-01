
using System.Collections.Generic;

using io.timetrack.common;

namespace io.timetrack.model {

    public class Project : IProject {

        public int Id { get; set; }

        public string Name { get; set; }

        public Person Manager { get; set; }

        public IEnumerable<Person> Team { get; set; }

        public IEnumerable<Tag> Tags { get; set; }

        #region EIMI

        IPerson IProject.Manager { get { return Manager; } }

        IEnumerable<ITag> IProject.Tags { get { return Tags; } }

        IEnumerable<IPerson> IProject.Team { get { return Team; } }

        #endregion
    }

}

