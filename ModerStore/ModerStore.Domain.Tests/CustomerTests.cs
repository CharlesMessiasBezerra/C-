using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModerStore.Domain.Entities;

namespace ModerStore.Domain.Tests
{
    [TestClass]
    public class CustomerTests
    {
        private  readonly User user = new User("Charles", "Messias");

        [TestMethod]
        [TestCategory("Customer - New Customer")]
        public void GivenAnInvalidFirstNameShouldReturANotification()
        {
            
            var customer = new Customer("charles","Messias","charlesgeek@gmail.com",user);
            Assert.IsFalse(customer.Isvalid());
        }

        [TestMethod]
        [TestCategory("Customer - New Customer")]
        public void GivenAnInvalidLastNameShouldReturANotification()
        {
            var customer = new Customer("charles", "messias", "charlesgeek@gmail.com", user);
            Assert.IsFalse(customer.Isvalid());
        }

        [TestMethod]
        [TestCategory("Customer - New Customer")]
        public void GivenAnInvalidEmailShouldReturANotification()
        {
            var customer = new Customer("charles", "messias", "charlesgeek@gmail.com", user);
            Assert.IsFalse(customer.Isvalid());
        }
    }
}
