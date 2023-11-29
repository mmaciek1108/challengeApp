
namespace challengeApp
{
    public class Supervisor : IEmployee
    {
        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; set; }
        public string Surname { get; set; }


        private List<float> grades = new List<float>();


        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception($"nieprawidłowe dane - liczba: {grade} nie miesci sie w przedziale 0-100");
            }
        }


        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    AddGrade(6);
                    break;
                case 'B':
                case 'b':
                    AddGrade(5);
                    break;
                case 'C':
                case 'c':
                    AddGrade(4);
                    break;
                case 'D':
                case 'd':
                    AddGrade(3);
                    break;
                case 'E':
                case 'e':
                    AddGrade(2);
                    break;
                default:
                    throw new Exception("nie właściwe wprowadzony znak");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;

            }
            return statistics;
        }
        public void AddGrade(string grade)
        {

            float points;
            char modifier = grade.Length > 1 ? grade[1] : ' ';

            switch (grade[0])
            {
                case '6':
                    points = 100;
                    break;
                case '5':
                    points = 80;
                    break;
                case '4':
                    points = 60;
                    break;
                case '3':
                    points = 40;
                    break;
                case '2':
                    points = 20;
                    break;
                case '1':
                    points = 0;
                    break;
                default:
                    throw new Exception("nie właściwe wprowadzony znak");
            }
            if (modifier == '+')
            {
                points += 5;
            }
            else if (modifier == '-')
            {
                points -= 5;
            }

            AddGrade(points);
        }
    }
}