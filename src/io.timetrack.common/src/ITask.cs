
using System.Collections.Generic;

namespace io.timetrack.common {

    public interface ITask : IIdentifiable {

        string Title { get; set; }

        string Description { get; set; }

        IEnumerable<ITag> Tags { get; }

    }

}
