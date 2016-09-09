
using System;
using System.Collections.Generic;

namespace io.timetrack.common {

    public interface IProject : IIdentifiable {

        String Name { get; set; }

        int ManagerId { get; set; }
        IPerson Manager { get; }

        IEnumerable<IRoleInProject> Team { get; }

        IEnumerable<ITag> Tags { get; }

    }

}

