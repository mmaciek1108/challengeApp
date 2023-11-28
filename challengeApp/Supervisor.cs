
namespace challengeApp
{
    public class Supervisor : IEmployee
    {
        public string Name => throw new NotImplementedException();

        public string Surname => throw new NotImplementedException();

        public int Age => throw new NotImplementedException();

        public char Sex => throw new NotImplementedException();

        public void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }


        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public Statistics GetStatistics()
        {
            throw new NotImplementedException();
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