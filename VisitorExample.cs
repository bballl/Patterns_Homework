namespace Patterns_State_Visitor_Observer_Bridge_Proxy
{
    public class VisitorExample
    {
        public VisitorExample()
        {
            var info = new InfoVisitor();
            AsteroidGreen asteroidGreen = new AsteroidGreen();
            AsteroidBlue asteroidBlue = new AsteroidBlue();
            asteroidGreen.Accept(info);
            asteroidBlue.Accept(info);

            var updateInfo = new UpdateInfoVisitor();
            AsteroidGreenBlue asteroidGreenBlue = new AsteroidGreenBlue();
            asteroidGreenBlue.Accept(updateInfo);
            asteroidGreen.Accept(updateInfo);
        }
    }
}
