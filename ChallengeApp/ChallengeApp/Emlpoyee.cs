

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade) 
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            
            foreach (var grade in this.grades)
            {
                statistics.Average += grade;
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
            }

            statistics.Average /= this.grades.Count;
            

            return statistics;
        }
        




        //public Employee(string name, string surname, int age)
        //{
        //    this.Name = name;
        //    this.Surname = surname;
        //    this.Age = age;
        //}


        //public string Name { get; set; }
        //public string Surname { get; set; }
        //public int Age { get; set; }

        //private List<int> score = new List<int>();

        //public int Result
        //{
        //    get
        //    {
        //        return score.Sum();
        //    }
        //}

        //public void AddScore(int score)
        //{
        //    this.score.Add(score);
        //}
        //public void ShowEmployee()
        //{
        //    Console.WriteLine(this.Name + " " + this.Surname);
        //    Console.WriteLine("Wiek: " + this.Age);
        //}

        //public void ShowResult()
        //{
        //    Console.WriteLine("Suma ocen: " + this.Result);
        //}
    }
}
