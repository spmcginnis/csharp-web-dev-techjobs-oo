using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        //Test Job Data
        private string xJobName = "Product Tester";
        private Employer xEmpName = new Employer("ACME");
        private Location xLoc = new Location("Desert");
        private PositionType xType = new PositionType("Quality Control");
        private CoreCompetency xComp = new CoreCompetency("Persistence");

        // TEST1: Each Job object should contain a unique ID number, and these should also be sequential integers

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.AreEqual(new Job().Id, new Job().Id - 1);
        }

        // TEST2: Each Job object should contain six properties-- Id, Name, EmployerName, EmployerLocation, JobType, and JobCoreCompetency

        [TestMethod]
        public void TestJobConstructorAllFields()
        {
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

            Job xJob1 = new Job(xJobName, xEmpName, xLoc, xType, xComp);
            Job xJob2 = new Job(xJobName, xEmpName, xLoc, xType, xComp);

            Assert.IsFalse(xJob1.Equals(xJob2));
        }

        // TEST4: When passed a job object, ToString() should return a string that contains a blank line before and after the job information

        [TestMethod]
        public void TestJobToStringFormat()
        {
            Job xJob = new Job(xJobName, xEmpName, xLoc, xType, xComp);

            string[] strLines = xJob.ToString().Split("\n");

            Assert.IsTrue(strLines[0] == "");
            Assert.IsTrue(strLines[strLines.Length - 1] == "");


        }

        // TEST5: The Job class ToString() method should contain a label for each field, followed by the data stored in that field.  Each field should be on its own line.

        [TestMethod]
        public void TestJobToStringFieldLines()
        {
            Job xJob = new Job(xJobName, xEmpName, xLoc, xType, xComp);
            string[] strLines = xJob.ToString().Split("\n");

            Assert.IsTrue(strLines[1] == $"ID: {xJob.Id}");
            Assert.IsTrue(strLines[2] == $"Name: {xJobName}");
            Assert.IsTrue(strLines[3] == $"Employer: {xEmpName}");
            Assert.IsTrue(strLines[4] == $"Location: {xLoc}");
            Assert.IsTrue(strLines[5] == $"Position Type: {xType}");
            Assert.IsTrue(strLines[6] == $"Core Competency: {xComp}");
        }

        // TEST6: ToString(): If a field is empty, the method should add "Data not available." after the label.
        [TestMethod]
        public void TestJobToStringNoData()
        {
            Job xJob = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
            string[] strLines = xJob.ToString().Split("\n");
            Assert.IsTrue(strLines[6] == "Core Competency: Data not available.");
            for (int i = 2; i < 7; i++)
            {
                Assert.IsTrue(strLines[i].Contains("Data not available."));
            }
        }



    }
}
