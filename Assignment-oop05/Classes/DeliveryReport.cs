using Assignment_oop05.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_oop05.Classes
{
    public class DeliveryReport
    {
        public void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine($" {shipment.GetTrackingStatus()}");
        }

        public void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine($" {shipment.CalculateInsurance()}");
        }
    }
}
