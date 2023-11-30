
namespace challengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public delegate void GradeAddedDeledate(object sender, EventArgs args);
        public abstract event GradeAddedDeledate GradeAdded;
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public abstract void AddGrade(float grade);
        public abstract void AddGrade(char grade);

        public abstract void AddGrade(string grade);
        public abstract Statistics GetStatistics();
    }
}