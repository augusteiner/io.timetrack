
using System.Collections.Generic;

namespace io.timetrack.common {

    public interface IPerson : IIdentifiable {

        string Name { get; set; }

        IEnumerable<IProject> Projects { get; }

    }

}
