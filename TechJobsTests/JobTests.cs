using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        // TEST1: Each Job object should contain a unique ID number, and these should also be sequential integers
        
        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.AreEqual(new Job().Id, new Job().Id - 1);
            /*            Job testJob1 = new Job();
                        Job testJob2 = new Job();
                        Assert.IsTrue(testJob1.Id == testJob2.Id -1);*/

        }

        // TEST2: Each Job object should contain six properties-- Id, Name, EmployerName, EmployerLocation, JobType, and JobCoreCompetency

        [TestMethod]
        public void TestJobConstructorAllFields()
        {
            string xJobName = "Product Tester";
            Employer xEmpName = new Employer("ACME");
            Location xLoc = new Location("Desert");
            PositionType xType = new PositionType("Quality Control");
            CoreCompetency xComp = new CoreCompetency("Persistence");

            Job xJob = new Job(xJobName, xEmpName, xLoc, xType, xComp);

            Assert.IsTrue(xJob.Id >= 1);
            Assert.AreEqual(xJobName, xJob.Name);
            Assert.AreEqual(xEmpName, xJob.EmployerName);
            Assert.AreEqual(xLoc, xJob.EmployerLocation);
            Assert.AreEqual(xType, xJob.JobType);
            Assert.AreEqual(xComp, xJob.JobCoreCompetency);
        }

        // TEST3: Two Job objects are considered equal if they have the same id value, even if one or more of the other fields differ.  Similarly, the two objects are NOT equal if their id values differ, even if all the other fields are identical.

        [TestMethod]
        public void TestJobEquality()
        {
            string xJobName = "Product Tester";
            Employer xEmpName = new Employer("ACME");
            Location xLoc = new Location("Desert");
            PositionType xType = new PositionType("Quality Control");
            CoreCompetency xComp = new CoreCompetency("Persistence");

            Job xJob1 = new Job(xJobName, xEmpName, xLoc, xType, xComp);
            Job xJob2 = new Job(xJobName, xEmpName, xLoc, xType, xComp);

            Assert.IsFalse(xJob1.Equals(xJob2));
        }


    }
}
