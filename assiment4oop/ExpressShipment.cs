using System;
using System.Collections.Generic;
using System.Text;

namespace assiment4oop
{
    public class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        public decimal ExtraFee { get; set; }

        public ExpressShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            decimal extraFee,
            DeliveryAddress destination)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination)
        {
            if (extraFee < 0)
                throw new ArgumentException("Extra fee cannot be negative.");

            ExtraFee = extraFee;
        }
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + ExtraFee + (Weight * 5);
            }
        }
        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Extra Fee : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Out for Delivery.";
        }
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }
    }
}
