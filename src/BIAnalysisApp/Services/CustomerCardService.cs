using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BIAnalysisApp.Services
{
    public interface ICustomerCardService
    {
        List<Customer> GetCustomers();

        List<Installation> GetInstallations();

        List<Card> GetCards();

        List<Location> GetLocations();

        List<Department> GetDepartments();

        List<Company> GetCompanies();


    }


    public class CustomerCardService : ICustomerCardService
    {
       
        public List<Customer> GetCustomers()
        {
            return new List<Customer>{
                new Customer {CustomerId =1, CustomerName="John" },
                new Customer {CustomerId =1, CustomerName="John1" },
                new Customer {CustomerId =1, CustomerName="John2" },
                new Customer {CustomerId =1, CustomerName="John3" }};
        }

        public List<Installation> GetInstallations()
        {
            return new List<Installation>{
                new Installation {InstallationId =1, InstallationName="Hotel r1" },
                new Installation {InstallationId =1, InstallationName="hotel r3" }
              };
        }

        public List<Card> GetCards()
        {
            return new List<Card>{
                new Card {CardId =1, CardName="mcard" },
                new Card {CardId =1, CardName="ecard" },
                new Card {CardId =1, CardName="ascard" },
                new Card {CardId =1, CardName="pcard" }};
        }

        public List<Location> GetLocations()
        {
            return new List<Location>{
                new Location {LocationId =1, LocationName="Oslo" },
                new Location {LocationId =1, LocationName="London" },
                new Location {LocationId =1, LocationName="Gothenberg" }};
        }

        public List<Department> GetDepartments()
        {
            return new List<Department>{
                new Department {DepartmentId =1, DepartmentName="dept1" },
                new Department {DepartmentId =1, DepartmentName="dept2" },
                new Department {DepartmentId =1, DepartmentName="dept3" },
                new Department {DepartmentId =1, DepartmentName="dept2" }};
        }

        public List<Company> GetCompanies() 
        {
            return new List<Company>{
                new Company {CompanyId =1, CompanyName="marcosift" },
                new Company {CompanyId =1, CompanyName="sas" },
                new Company {CompanyId =1, CompanyName="norske" },
                new Company {CompanyId =1, CompanyName="pass" }};
        }
    }



    public class Customer
    {
        public int CustomerId { get; set; }

        public string  CustomerName { get; set; }
    }


    public class Installation
    {
        public int InstallationId { get; set; }

        public string InstallationName { get; set; }
    }

    public class Company
    {
        public int CompanyId { get; set; }

        public string CompanyName { get; set; }
    }

    public class Location
    {
        public int LocationId { get; set; }

        public string LocationName { get; set; }
    }


    public class Card
    {
        public int CardId { get; set; }

        public string CardName { get; set; }
    }

    public class Department
    {
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }
    }

}