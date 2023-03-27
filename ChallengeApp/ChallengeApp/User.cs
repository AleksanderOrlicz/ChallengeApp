

namespace ChallengeApp
{
    public class User
    {
        private List<int> score = new List<int>();
        
        public User(string name)
        {
            this.Login = name;
        }
        public User(string name, string password)
        {
            this.Login = name;
            this.Password = password;
        }

        public string Login { get; private set; }
        public string Password { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number)
        {
            score.Add(number);            
        }

        public void PenaltyScore(int number) 
        {
            score.Add(-number);
        }
    }
}
