
using System.Collections.Generic;

using io.timetrack.common;

namespace io.timetrack.model {

    public class Project : IProject {

        public int Id { get; set; }

        public string Name { get; set; }

        public int ManagerId { get; set; }
        public Person Manager { get; set; }

        public ICollection<RoleInProject> Team { get; set; }

        public ICollection<Tag> Tags { get; set; }

        #region EIMI

        IPerson IProject.Manager { get { return Manager; } }

        IEnumerable<ITag> IProject.Tags { get { return Tags; } }

        IEnumerable<IRoleInProject> IProject.Team { get { return Team; } }

        #endregion
    }

}

