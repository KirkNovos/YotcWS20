using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RegZnak;

namespace REG_MARK_TEST
{
    [TestClass]
    public class UnitTest1
    {

        static REG_MARK reg_mark;
        [ClassInitialize]
        static public void Init(TestContext tc)
        {
            reg_mark = new REG_MARK();
        }

        [TestMethod]
        public void CheckMarkValidation()
        {
            Assert.IsTrue(reg_mark.CheckMark("a999aa999"));
        }
    }
}
