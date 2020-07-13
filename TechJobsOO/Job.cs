using System;
using System.Collections.Generic;
using System.Linq;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.  DONE

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer empName, Location empLoc, PositionType jobType, CoreCompetency jobCoreComp) : this()
        {
            this.Name = name;
            this.EmployerName = empName;
            this.EmployerLocation = empLoc;
            this.JobType = jobType;
            this.JobCoreCompetency = jobCoreComp;
        }
        
        
        // TODO: Generate Equals() and GetHashCode() methods.  DONE

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string noData = "Data not available";

            Tuple<string, string>[] valuesToPrint =
                        {   new Tuple<string, string>("ID: ", this.Id.ToString()),
                            new Tuple<string, string>("Name: ", this.Name.ToString()),
                            new Tuple<string, string>("Employer: ", this.EmployerName.ToString()),
                            new Tuple<string, string>("Location: ", this.EmployerLocation.ToString()),
                            new Tuple<string, string>("Position Type: ", this.JobType.ToString()),
                            new Tuple<string, string>("Core Competency: ", this.JobCoreCompetency.ToString())   };

            List<string> outputStringList = new List<string>();

            foreach (Tuple<string, string> n in valuesToPrint)
            {
                if (n.Item2.Length > 0)
                {
                    outputStringList.Add(n.Item1 + n.Item2);
                }
                else
                {
                    outputStringList.Add(n.Item1 + noData);
                }
            }

            string outputString = string.Join("\n", outputStringList);

            return $"\n" + outputString + "\n";
        }





    }
}
