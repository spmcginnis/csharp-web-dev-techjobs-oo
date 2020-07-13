using System;
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





    }
}
