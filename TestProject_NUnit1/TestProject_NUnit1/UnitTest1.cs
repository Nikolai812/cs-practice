namespace TestProject_NUnit1
{
    [TestFixture]
    public class Tests
    {
        private List<int> cData = new List<int> { 8, 3, 1, 1, 49, 5 };
        private Queue<int> queue = new Queue<int>([1, 2, 88, 5, 4]);
        private Stack<int> stack = new Stack<int>([1, 2, 88, 5, 4]);


        // Parameterized test using the [TestCaseSource] attribute
        private static IEnumerable<TestCaseData> TestData()
        {
            yield return new TestCaseData(2, 3, 5);
            yield return new TestCaseData(0, 0, 0);
            yield return new TestCaseData(-1, 1, 0);
        }

        [SetUp]
        public void Setup()
        {
            
        }

        
        [Test]
        [TestCase(0,8)]
        [TestCase(1,3)]
        public void Test1(int index, int expectedValue)
        {
            Console.WriteLine("Test1 going");
            Assert.That(cData[index], Is.EqualTo(expectedValue));
        }

        [Test]
        public void Test2()
        {
            Console.WriteLine("Test2 going");
            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}