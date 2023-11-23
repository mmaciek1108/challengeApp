
using challengeApp;

namespace CSzarpKurs
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >=0 && grade <=200)
            {
            this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine($"nieprawidłowe dane - liczba: {grade} nie miesci sie w przedziale 0-200");
            }
        }

        public void AddGrade(string grade)
        {   
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine($"Wpisany znak: {grade} - nie da się przekonwertować na liczbę");
            }
        }

        public void AddGrade(double grade)
        {   
           float gradeFloat = (float)grade;
           this.AddGrade(gradeFloat);
        }
 
        public void AddGrade(char grade)
        {   
            double numericValue = Char.GetNumericValue(grade);
            if (numericValue >= 0)
           {
                float gradeFloat = (float)numericValue;
                this.AddGrade(gradeFloat);
           }
           else
           {
            Console.WriteLine($"nieprawidłowy znak: {grade}");
           }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach(var grade in this.grades) 
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            
            statistics.Average /= this.grades.Count;

            return statistics;
        }
    }
}