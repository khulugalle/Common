using Common.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
namespace Common.Log4Net.Test
{
    [TestClass]
    public class Log4NetTest
    {
        private ILogger logger;

        [TestInitialize]
        public void Setup()
        {
            logger = new Log4Net();
        }

        [TestCleanup]
        public void TearDown()
        {

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

        [TestMethod]
        public void LogInfoTest()
        {
            // Should throw exception if fails
            logger.Info("Test Info");
        }

        [TestMethod]
        public void LogTraceTest()
        {
            // Should throw exception if fails
            logger.Trace("Test Trace");
        }

        [TestMethod]
        public void LogDebugTest()
        {
            // Should throw exception if fails
            logger.Debug("Test Debug");
        }

        [TestMethod]
        public void LogWarnTest()
        {
            // Should throw exception if fails
            logger.Warn("Test Warn");
        }

        [TestMethod]
        public void LogErrorTest()
        {
            // Should throw exception if fails
            logger.Error("Test Error");
        }

        [TestMethod]
        public void LogFatalTest()
        {
            // Should throw exception if fails
            logger.Fatal("Test Fatal");
        }
    }
}
