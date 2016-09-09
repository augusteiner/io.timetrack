
using System.Collections.Generic;

using io.timetrack.common;

namespace io.timetrack.model {

    public class Task : ITask {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int AssignedToId { get; set; }
        public Person AssignedTo { get; set; }

        public int CreatedById { get; set; }
        public Person CreatedBy { get; set; }

        public ICollection<Tag> Tags { get; set; }

        #region EIMI

        IPerson ITask.AssignedTo { get { return AssignedTo; } }

        IPerson ITask.CreatedBy { get { return CreatedBy; } }

        IEnumerable<ITag> ITask.Tags { get { return Tags; } }

        #endregion

    }

}
