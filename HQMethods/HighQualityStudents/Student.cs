using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighQualityStudent
{
    class Student
    {
        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;

        /// <summary>
        /// Create Student by giving names and date of birth
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthDate"></param>
        public Student(string firstName,string lastName, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
        }

        /// <summary>
        /// Student first name
        /// </summary>
        public string FirstName
        {
            get { return this._firstName; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(FirstName),"First name can not be empty or null!");
                }
                this._firstName = value;
            }
        }

        /// <summary>
        /// Student last name
        /// </summary>
        public string LastName
        {
            get { return this._lastName; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(LastName),"Last name can not be empty or null!");
                }
                this._lastName = value;
            }
        }

        /// <summary>
        /// Student full name
        /// </summary>
        public string FullName
        {
            get { return string.Format("{0} {1}", this.FirstName, this.LastName); }
        }

        /// <summary>
        /// Student birth date
        /// </summary>
        public DateTime BirthDate
        {
            get { return this._birthDate; }
            private set
            {
                var minimalBirthDate = new DateTime(1940, 1, 1);
                if (value < minimalBirthDate || value > DateTime.Now)
                {
                    throw new ArgumentException(string.Format
                        ("BirthDate must be in the range {0} - {1}", minimalBirthDate.ToString(CultureInfo.InvariantCulture),
                            DateTime.Now.ToString(CultureInfo.InvariantCulture)));
                }
                this._birthDate = value;
            }
        }

        /// <summary>
        /// Compare two students if this student is older
        /// return true, otherwise return false
        /// </summary>
        /// <param name="other"></param>
        /// <returns>boolean value</returns>
        public bool CompareStudentsBirthDates(Student other)
        {
            bool isStudentOlder = this.BirthDate.CompareTo(other.BirthDate) < 0;
            return isStudentOlder;
        }

        /// <summary>
        /// Text information about this student
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Name: {0}, Birth Date: [{1}.{2}.{3} year]", this.FullName, this.BirthDate.Day,
                this.BirthDate.Month, this.BirthDate.Year);
        }
    }
}
