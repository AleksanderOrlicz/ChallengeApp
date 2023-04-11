namespace ChallengeApp
{   public abstract class Person
    {
        public Person()
            : this ("no name")
        {            
        }
        public Person(string name)
            : this(name, "no surname")
        {
            this.Name = name;            
        }
        public Person(string name, string surname)
            : this(name, surname, 'N')
        {
            this.Name = name;
            this.Surname = surname;
        }
        public Person(string name, string surname, char sex)
            : this(name, surname, sex, 0)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;            
        }
        public Person(string name, string surname, char sex, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Sex { get; private set; }
        public int Age { get; private set; }
    }
}
