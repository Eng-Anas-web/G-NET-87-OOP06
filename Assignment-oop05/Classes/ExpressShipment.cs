using Assignment_oop05.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_oop05.Classes
{
    public class ExpressShipment : Shipment, ITrackable, IInsurable
    {

        #region Feildes
        private decimal ExtraFee;

        #endregion

        #region Constructors
        public ExpressShipment(decimal extraFee, string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            if (extraFee >= 0)
            {
                ExtraFee = extraFee;
            }
        }

        #endregion

        #region FunctionOverride
        public override decimal EstimatedCost => DeliveryFee + ((decimal)Weight * 5) + ExtraFee;

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Out for Delivery.";
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
            Console.WriteLine($"Extra Fee: {ExtraFee} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
        #endregion


    }
}
