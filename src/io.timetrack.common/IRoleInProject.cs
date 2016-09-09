
namespace io.timetrack.common {

    public interface IRoleInProject : IIdentifiable {

        int PersonId { get; set; }
        IPerson Person { get; }

        int RoleId { get; set; }
        IRole Role { get; }

        int ProjectId { get; set; }
        IProject Project { get; }

    }

}
