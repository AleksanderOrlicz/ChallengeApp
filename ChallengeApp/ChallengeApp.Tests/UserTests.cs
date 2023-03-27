//Zadanie 
//Przygotowaæ projekt testowy
//Czy implementacja pracownika dzia³a poprawnie
//Metoda odejmowania punktów
// 5 + 5 + 2 - 12 = 0


namespace ChallengeApp.Tests
{
    public class UserTests
    {
        [Test]
        public void WhenUserCollectTwoScores_ShouldReturnCorrectResult()
        {
            // arrange
            var user = new User("Aleksander", "1996");

            user.AddScore(5);
            user.AddScore(6);
            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(11, result);

        }

        [Test]
        public void WhenUserCollectScoresAndNegativePoints_ReturnsCorrectResult()
        {
            var expected = 0;
            var user = new User("Henry", "1234");

            user.AddScore(5);
            user.AddScore(5);
            user.AddScore(2);
            user.AddScore(-12);

            var result = user.Result;

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void WhenUsercollectPointsButGetsPenaltyPoints_ReturnCorrectResult()
        {
            var expected = 2;
            var user = new User("Hetzwig", "4328");

            user.AddScore(5);
            user.AddScore(5);
            user.AddScore(2);
            user.PenaltyScore(10);

            var result = user.Result;

            Assert.That(result, Is.EqualTo(expected));


        }
    }
}