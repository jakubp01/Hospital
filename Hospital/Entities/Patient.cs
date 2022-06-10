using System;

namespace Hospital.Entities
{
    public class Patient
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string IdentificationNumber { get; set; }

        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
