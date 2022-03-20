namespace Brandon_Morgado_C969_Scheduling
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class appointment
    {
        public int AppointmentId;
        public int CustomerId;
        public int UserId;
        public string Title;
        public string Description;
        public string Location;
        public string Contact;
        public string Type;
        public string Url;
        public DateTime StartTime;
        public DateTime EndTime;



        public appointment(int appointmentId, int customerID, int userID, string title, string description, string location, string contact, string type, string url, DateTime startTime, DateTime endTime)
        {
            AppointmentId = appointmentId;
            CustomerId = customerID;
            UserId = userID;
            Title = title;
            Description = description;
            Location = location;
            Contact = contact;
            Type = type;
            Url = url;
            StartTime = startTime;
            EndTime = endTime;

        }
    }
}
