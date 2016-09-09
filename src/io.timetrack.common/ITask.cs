
using System.Collections.Generic;

namespace io.timetrack.common {

    public interface ITask : IIdentifiable {

        string Title { get; set; }

        string Description { get; set; }

        int AssignedToId { get; }
        IPerson AssignedTo { get; }

        int CreatedById { get; }
        IPerson CreatedBy { get; }

        IEnumerable<ITag> Tags { get; }

    }

}
