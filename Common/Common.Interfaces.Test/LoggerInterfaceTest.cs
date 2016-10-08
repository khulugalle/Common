using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common.Interfaces.Test.Supporting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Common.Interfaces.Test
{
    /// <summary>
    /// Test that all the methods for the interface are called correctly
    /// </summary>
    [TestClass]
    public class LoggerInterfaceTest
    {

        private ILogger logger;

        [TestInitialize]
        public void Setup()
        {
            logger = new LoggerInterfaceConcrete();
        }

        [TestCleanup]
        public void TearDown()
        {

        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void IsTraceEnabledTest()
        {
            IsTrue(logger.TraceEnabled);
        }

        [TestMethod]
        public void IsDebugEnabledTest()
        {
            IsTrue(logger.DebugEnabled);
        }

        [TestMethod]
        public void IsWarnEnabledTest()
        {
            IsTrue(logger.WarnEnabled);
        }

        [TestMethod]
        public void IsErrorEnabledTest()
        {
            IsTrue(logger.ErrorEnabled);
        }

        [TestMethod]
        public void IsFatalEnabledTest()
        {
            IsTrue(logger.FatalEnabled);
        }
    }
}
