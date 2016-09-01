
using System.Collections.Generic;

using io.timetrack.common;

namespace io.timetrack.model {

    public class Task : ITask {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        ICollection<Tag> Tags { get; set; }

        #region EIMI

        IEnumerable<ITag> ITask.Tags { get { return Tags; } }

        #endregion

    }

}
