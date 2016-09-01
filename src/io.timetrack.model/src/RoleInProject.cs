
using io.timetrack.common;

namespace io.timetrack.model {

    public class RoleInProject : IRoleInProject
    {
        public int Id { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        #region EIMI

        IPerson IRoleInProject.Person { get { return Person; } }

        IRole IRoleInProject.Role { get { return Role; } }

        IProject IRoleInProject.Project { get { return Project; } }

        #endregion

    }

}
