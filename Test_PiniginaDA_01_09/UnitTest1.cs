using PiniginaDA_01_09;

namespace Test_PiniginaDA_01_09
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestBaseQuality()
        {
            RoadWorks roadworks = new RoadWorks(100.1, 1051.5, 10.7);
            double res = roadworks.QualityRoad();
            double exception = 1126.23;
            Assert.AreEqual(exception,res);
        }

        [Test]
        public void TestChildRange5to8()
        {
            RoadWorksChild roadWorksChild = new RoadWorksChild(102.2, 1500, 21, 6);
            double res = roadWorksChild.QualityRoad();
            double exception = 3541.23;
            Assert.AreEqual(exception ,res);
        }
        [Test]
        public void TestChild3or4or9or10()
        {
            RoadWorksChild roadWorksChild = new RoadWorksChild(200.1, 2002.3, 25.2, 9);
            double res = roadWorksChild.QualityRoad();
            double exception = 16154.62;
            Assert.AreEqual(exception,res);
        }
        [Test]
        public void TestChildToOthers()
        {
            RoadWorksChild roadWorksChild = new RoadWorksChild(122.3, 2355, 12.1, 15);
            double res=roadWorksChild.QualityRoad();
            double exception =6621.5;
            Assert.AreEqual(exception, res);
        }
    }
}