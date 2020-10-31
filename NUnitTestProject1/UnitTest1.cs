using CabInvoiceGenerator;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        /// <summary>
        /// UC 1:
        /// Given distance and time should return total fare
        /// </summary>
        public InvoiceGenerator invoiceGenerator = null;
        
        [Test]
        public void GivenDistanceAndTime_ReturnsTotalFare()
        {
            double distance = 5.0;
            int time = 10;
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double actualFare = invoiceGenerator.CalculateFare(distance, time);
            double expectedFare = 60.0;
            /// Assert
            Assert.AreEqual(expectedFare, actualFare);
        }
        /// <summary>
        /// UC 2 : 
        /// Given multiple rides should return invoice summary with aggregate totalFare
        /// </summary>
        [Test]
        public void GivenMultipleRides_ShouldReturnInvoiceSummary()
        {
            // Arrange
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(3, 5), new Ride(5, 4) };
            InvoiceSummary expectedSummary = new InvoiceSummary(3, 116);
            // Act
            InvoiceSummary actualSummary = invoiceGenerator.CalculateFare(rides);
            //Assert
            Assert.AreEqual(expectedSummary, actualSummary);
        }
    }
}