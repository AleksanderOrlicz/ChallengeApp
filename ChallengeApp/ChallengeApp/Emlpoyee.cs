//Przygotować kilka metod na przyjęcie ocen w różnych formatach
//AddGrade z różnymi typami parametrów,
//ale ostatecznie wywołanie AddGrade(float)
//double
//long
//inne typy

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



        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }

        public void AddGrade(long grade)
        {
            var gradeInFloat = (float)grade;
            AddGrade(gradeInFloat);
        }

        public void AddGrade(double grade)
        {
            var gradeInFloat = (float)grade;
            AddGrade(gradeInFloat);

        }

        public void AddGrade(int grade)
        {
            var gradeInFloat = (float)grade;
            AddGrade(gradeInFloat);
        }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
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
                //break
                //continue
                //goto                
                if (grade >= 0)
                {
                    statistics.Average += grade;
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                }
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithForEach()
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
            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (var i = 0; i < this.grades.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Average += this.grades[i];
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];

                index++;
            } while (index < this.grades.Count);

            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0;

            while (index < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];

                index++;
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
