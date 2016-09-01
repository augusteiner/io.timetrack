
using System;
using System.Collections.Generic;

namespace io.timetrack.common {

    public interface IProject : IIdentifiable {

        String Name { get; set; }

        IPerson Manager { get; }

        IEnumerable<IPerson> Team { get; }

        IEnumerable<ITag> Tags { get; }

    }

}

