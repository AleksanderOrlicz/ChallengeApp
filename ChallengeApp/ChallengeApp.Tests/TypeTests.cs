namespace ChallengeApp.Tests
{
    
    //poporawić nazwy testów
    //testy dla int, float, string
    //dla typów referencyjnych
    //wszystkie mają być zielone
    
    public class TypeTests
    {
        [Test]
        public void WhenIntegersHasSameValue_ShouldReturnEqualValues()
        {
            int int1 = 2;
            int int2 = 2;

            Assert.AreEqual(int1, int2);
        }

        [Test]
        public void WhenFloatHasSameValue_ShouldReturnEqualValues()
        {
            float float1 = 2.323232E2f;
            float float2 = 232.3232f;

            Assert.AreEqual(float1, float2);
        }
        
        [Test]
        public void WhenStringsAreTheSame_ShouldReturnEqualValues()
        {
            //arrange
            string string1 = "Adam";
            string string2 = "Adam";

            //act

            //assert
            Assert.AreEqual(string1, string2);
        }

        [Test]
        public void WhenStringsAreDifferent_ShouldReturnNotEqualValues()
        {
            string string1 = "Aleksander";
            string string2 = "Anna";

            Assert.IsFalse(string1.Equals(string2));
        }

        [Test]
        public void TwoAtributesGetUserShouldReturnDifferentObjects()
        {
            var user1 = GetUser("Aleksander", "1234");
            var user2 = GetUser("Aleksander", "1234");

            Assert.AreNotEqual(user1, user2);
        }

        [Test]
        public void OneAtributeGetUserShouldReturnDifferentObjects()
        {
            //arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            //act

            //assert
            Assert.AreNotEqual(user1, user2);
        }


        private User GetUser(string name, string password)
        {
            return new User(name, password);
        }
        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}
