using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Encapsulation
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;
        public Person()
        {

        }

        public Person(string firstname, string lastName, int age )
        {
            this.FirstName = firstname;
            this.LastName = LastName;

            this.Age = age;
        }

        public string FirstName
        {
            get
            {
               return  this.firstName;
            }
            internal set
            {
                CommonValidator.ValidateNull(value, "Person first name");
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            internal set
            {
                if (value == null)
                {
                    throw new InvalidOperationException("Person Last name cannot be null");
                }
                //CommonValidator.ValidateNull(value, nameof(Person), nameof(this.LastName));

                this.lastName = value;
            }
        }
        public int Age 
        {
            get
            {
                return this.age;
            }
            internal set
            {
                //if(value < 30)
                //{
                //    throw new InvalidOperationException("Invalid age.");
                //}
                CommonValidator.ValidateMin(value, 0, nameof(Person), nameof(Person.Age));

                this.age = value;
            }
        }
        public string Gender { get; internal set; }
        public DateTime BirthDay { get; internal set; }

        public decimal Salary
        {
            get
            {
                return this.salary; 
            }
            internal set
            {
                CommonValidator.ValidateMin(value, 460, nameof(Person), nameof(this.Salary));
                this.salary = value;
            }
        }

        public Person RegisterForExam()
        {
            //Logic registration
            return this;
        }

        public Person ParticipateInExam()
        {
            //Logic participation
            return this;
        }

        public Person CalculateScore()
        {
            //Logic Score
            return this;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            var delimiter = 100;
            if(this.Age < 30)
            {
                delimiter = 200;
            }

            this.Salary += this.Salary * percentage / delimiter;

        }
    }
}
