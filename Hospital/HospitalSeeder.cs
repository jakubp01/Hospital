using Hospital.DbContextAndBuilders.ApiDbContext;
using Hospital.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital
{
    public class HospitalSeeder
    {
        Random random = new Random();
        private readonly HospitalDbContext _dbContext;
        public HospitalSeeder(HospitalDbContext dbContext)
        {
            _dbContext = dbContext;
        }



        public void seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Doctors.Any())
                {
                    var doctors = GetDoctors();
                    _dbContext.Doctors.AddRange(doctors);
                    _dbContext.SaveChanges();
                }
                if(!_dbContext.Patients.Any())
                {
                    var patients = GetPatients();
                    _dbContext.Patients.AddRange(patients);
                    _dbContext.SaveChanges();
                   
                }
                if(!_dbContext.Visits.Any())
                {
                    var visits = GetVisits();
                    _dbContext.Visits.AddRange(visits);
                    _dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Doctor> GetDoctors()
        {
            var doctors = new List<Doctor>()
                {
                    new Doctor()
                    {
                        Name = "Tomek Tomczak",
                        Specialization = "podiatrist",
                        ContactNumber = "111222333",
                        IdentificationNumber = "3423",
                        Gender = "Male",
                        DateOfBirth = new DateTime(1934,02,28)

                    },

                    new Doctor()
                    {
                         Name = "Jakub Jakubowski",
                        Specialization = "podiatrist",
                        ContactNumber = "121232334",
                        IdentificationNumber = "3125",
                        Gender = "Male",
                        DateOfBirth = new DateTime(1956,03,01)
                    }
                };
            return doctors;
        }
        private IEnumerable<Patient> GetPatients()
        {
            var patients = new List<Patient>()
            {
                new Patient()
                {
                    Name="Zosia Kowalewska",
                    IdentificationNumber = "1111",
                    Gender= "Female",
                    DateOfBirth = new DateTime(2001,02,01)
                },

                new Patient()
                {
                    Name="Maga Perła",
                    IdentificationNumber = "1112",
                    Gender= "Female",
                    DateOfBirth = new DateTime(1999,02,01)
                }

            };
            return patients;

        }
        private IEnumerable<Visit> GetVisits()
        {
            var visits = new List<Visit>()
            {
                new Visit()
                {
                    DateOfVisit = new DateTime(2022,06,16),
                    DoctorId = 1,
                    PatientId = 2,

                },
                new Visit()
                {
                    DateOfVisit = new DateTime(2022,07,01),
                    DoctorId =1,
                    PatientId = 1
                }

            };
            return visits;
        }

    }
}
