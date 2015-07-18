using System;
using System.Collections.Generic;
using System.Linq;
using Exceptions.Exams;

namespace Exceptions
{
    internal class Student
    {
        private string _firstName;
        private string _lastName;
        private readonly IList<Exam> _exams;

        public Student(string firstName, string lastName, IList<Exam> exam = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this._exams = exam;
        }

        public string FirstName
        {
            get { return this._firstName; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(_firstName),"First name can not be null or empty!");
                }
                this._firstName = value;
            }
        }
        public string LastName
        {
            get { return this._lastName; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(_lastName), "Last name can not be null or empty!");
                }
                this._lastName = value;
            }
        }

        public string FullName
        {
            get { return string.Format("{0} {1}", this.FirstName, this.LastName); }
        }

        public IList<Exam> Exams
        {
            get { return this._exams; }
        }

        public IList<ExamResult> CheckExamsResults()
        {           
            IList<ExamResult> examResults = new List<ExamResult>();
            for (int exam = 0; exam < this.Exams.Count; exam++)
            {
                examResults.Add(this.Exams[exam].Check());
            }

            return examResults;
        }

        public double CalculateAverageExamResultInPercents()
        {
            var examsScore = new double[this.Exams.Count];
            var examResults = this.CheckExamsResults();

            for (int examResult = 0; examResult < examResults.Count; examResult++)
            {
                examsScore[examResult] = examResults[examResult].CalculateExamResults();
            }

            return examsScore.Average();
        }
    }
}
