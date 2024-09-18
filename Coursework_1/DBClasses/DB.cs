using Coursework_1.App_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework_1.DBClasses
{
    internal class DB
    {

        internal static List<Admin> admins = new List<Admin>();

        internal static List<Appoainment> appoainments = new List<Appoainment>();

        internal static List<Front_Officer> front_officers = new List<Front_Officer>();

        internal static List<Patient> patients = new List<Patient>();

        internal static List<Payment> payments = new List<Payment>();

        internal static List<Surgeon> surgeons = new List<Surgeon>();

        internal static List<Treatment_Type> treatment_types = new List<Treatment_Type>();

        internal static void loadFkData()
        {
            //Admin Default Data
            admins.Add(new Admin(1, "Urshath", "Batticaloa", "0774519176" , "urshath" , "0000"));
            admins.Add(new Admin(2, "Ahamed", "Colombo", "0750052698", "ahamed", "2025"));
            admins.Add(new Admin(3, "Fathima", "Kandy", "0750289632", "fathi", "5569"));

            //Treatment Type Default Data
            treatment_types.Add(new Treatment_Type(1, "Cleanings", "2000"));
            treatment_types.Add(new Treatment_Type(2, "Whitening", "3000"));
            treatment_types.Add(new Treatment_Type(3, "Filling", "5000"));
            treatment_types.Add(new Treatment_Type(4, "Nerve Filling", "8000"));
            treatment_types.Add(new Treatment_Type(5, "Root Canal Therapy  ", "20000"));

            //Patient Default Data
            patients.Add(new Patient(1, "Kamal", "Batticaloa", "0775212369", "Male", "30"));
            patients.Add(new Patient(2, "Ruwan", "Colombo", "0775212000", "Male", "28"));
            patients.Add(new Patient(3, "Meri", "Kandy", "0700212369", "Female", "25"));

            //Surgeon Default Data
            surgeons.Add(new Surgeon(1, "Dr.Alith", "Colombo", "0774512963"));
            surgeons.Add(new Surgeon(2, "Dr.Sanath", "Kandy", "0702598663"));

            //Front Officer Default Data
            front_officers.Add(new Front_Officer(1, "Farhan", "Batticaloa", "0774519176","farhan", "1111", Admin.getObjectByID("1")));
            front_officers.Add(new Front_Officer(2, "Kelvin", "Polannaruwa", "0774519176", "kelvi", "0000", Admin.getObjectByID("2")));
            front_officers.Add(new Front_Officer(3, "Mohamed", "Batticaloa", "0774519176", "mohamed", "2563", Admin.getObjectByID("3")));

            //Appoainment Default Data
            appoainments.Add(new Appoainment(1, "Wednesday. December 27. 2023", "1000", Front_Officer.getObjectByID("1"), Patient.getObjectByID("1"), Surgeon.getObjectByID("1"), Treatment_Type.getObjectByID("1")));
            appoainments.Add(new Appoainment(2, "Friday. December 29. 2023", "1000", Front_Officer.getObjectByID("2"), Patient.getObjectByID("2"), Surgeon.getObjectByID("2"), Treatment_Type.getObjectByID("4")));
            appoainments.Add(new Appoainment(3, "Sunday. December 24. 2023", "1000", Front_Officer.getObjectByID("1"), Patient.getObjectByID("3"), Surgeon.getObjectByID("1"), Treatment_Type.getObjectByID("3")));
        }

    }
}
