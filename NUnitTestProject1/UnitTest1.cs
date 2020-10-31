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
    }
}