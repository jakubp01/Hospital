using System;

namespace Hospital.Models
{
    public class VisitDto
    {
        public int Id { get; set; }
        public DateTime DateOfVisit { get; set; }
        public string DoctorName { get; set; }
        public string PatientName { get; set; }

    }
}
