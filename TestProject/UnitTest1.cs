using EFLearn.DataWiz;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            LearningContext dbContext= new LearningContext();
            if(dbContext == null) { Assert.Fail(); }
            Assert.Pass();
        }
    }
}