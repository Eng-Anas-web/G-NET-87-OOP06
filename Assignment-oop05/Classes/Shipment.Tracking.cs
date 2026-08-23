using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_oop05.Classes
{
    public abstract partial class Shipment
    {
        private string _trackingStatus = "Pending";

        public string TrackingStatus
        {
            get { return _trackingStatus; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _trackingStatus = value;
                }
            }
        }

        public string GetTrackingStatus()
        {
            return _trackingStatus;
        }

        public void UpdateTrackingStatus(string newStatus)
        {
            if (!string.IsNullOrWhiteSpace(newStatus))
            {
                _trackingStatus = newStatus;

                OnTrackingStatusChanged(newStatus);
            }
        }
        partial void OnTrackingStatusChanged(string newStatus);
    }
}
