using FluentValidatorCore.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentValidatorCore.Tests
{
    [TestClass]
    public class BoolValidationContractTests
    {
        [TestMethod]
        [TestCategory("BoolValidation")]
        public void IsTrue()
        {
            var wrong = new ValidationContract()
                .Requires()
                .IsTrue(false, "bool", "Bool is false");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .Requires()
                .IsTrue(true, "bool", "Bool is false");
            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("BoolValidation")]
        public void IsFalse()
        {
            var wrong = new ValidationContract()
                .Requires()
                .IsFalse(true, "bool", "Bool is true");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .Requires()
                .IsFalse(false, "bool", "Bool is true");
            Assert.AreEqual(true, right.Valid);
        }
    }
}