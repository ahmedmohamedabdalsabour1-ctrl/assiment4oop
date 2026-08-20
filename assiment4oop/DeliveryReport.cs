using System;
using System.Collections.Generic;
using System.Text;

namespace assiment4oop
{
    public class DeliveryReport
    {
        public void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }
        public void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine(
                $"Insurance Cost : {shipment.CalculateInsurance():0.00} EGP");
        }
    }
}
