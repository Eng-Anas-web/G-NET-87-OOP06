using Assignment_oop05.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_oop05.Classes
{
    public class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        #region Feilds
        private string DestinationCountry;
        private decimal CustomsFee;
        #endregion

        #region Constructor
        public InternationalShipment(string destinationCountry, decimal customsFee, string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            if (!string.IsNullOrWhiteSpace(destinationCountry))
            {
                DestinationCountry = destinationCountry;
            }

            if (customsFee >= 0)
            {
                CustomsFee = customsFee;
            }
        }

        #endregion

        #region FunctionOverride
        public override decimal EstimatedCost => DeliveryFee + ((decimal)Weight * 5) + CustomsFee;

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} has been Delivered.";
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
            Console.WriteLine($"Delivery Fee: {DestinationCountry}");
            Console.WriteLine($"Extra Fee: {CustomsFee} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
        #endregion
    }
}
