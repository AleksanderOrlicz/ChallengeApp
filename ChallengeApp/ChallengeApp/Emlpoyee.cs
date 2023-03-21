

namespace ChallengeApp
{
    public class Employee
    {
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        private List<int> score = new List<int>();

        public int Result
        {
            get
            {
                return score.Sum();
            }
        }

        public void AddScore(int score)
        {
            this.score.Add(score);
        }
        public void ShowEmployee()
        {
            Console.WriteLine(this.Name+ " "+this.Surname);
            Console.WriteLine("Wiek: " + this.Age);
        }

        public void ShowResult()
        {
            Console.WriteLine("Suma ocen: " + this.Result);
        }


    }
}
