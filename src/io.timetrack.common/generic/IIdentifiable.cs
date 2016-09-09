
namespace io.timetrack.common.generic {

    public interface IIdentifiable<out T> {

        T Id { get; }

    }

}

