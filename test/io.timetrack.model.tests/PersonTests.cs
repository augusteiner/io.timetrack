
using System.Collections.Generic;

using Xunit;

namespace io.timetrack.model.tests {

    public class PersonTests {

        [Fact]
        public void EnsuresPersonHasName() {

            var pName = "John";
            var person = new Person() { Name = pName };

            Assert.Equal(person.Name, pName);

        }

        [Fact]
        public void EnsuresPersonHasProjects() {

            var person = new Person() {
                Projects = new List<Project>() { } };

            Assert.NotNull(person.Projects);

        }

    }

}
