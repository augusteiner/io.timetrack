
using System;
using System.Collections.Generic;

using io.timetrack.common;
using io.timetrack.model;

namespace io.timetrack.cli {

    class Program {

        static void Main(string[] args) {

            IEnumerable<IProject> projects = new List<Project>() {

                new Project(){ Name = "Project #1" }

            };

            foreach (IProject project in projects) {

                Console.WriteLine(project.Name);

            }

        }

    }

}

