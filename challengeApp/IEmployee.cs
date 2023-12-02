
using static challengeApp.EmployeeBase;

namespace challengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }

        void AddGrade(float grade);
        void AddGrade(char grade);
        void AddGrade(string grade);

        event GradeAddedDeledate GradeAdded;

        Statistics GetStatistics();
    }
}