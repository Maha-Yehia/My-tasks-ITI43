namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GameEngine (Director)
            GameEngine gameEngine = new GameEngine();

            //IPlatGroundBuilder (builder)
            IPlayGroundBuilder builder1 = new PlayGroundBuilder1(); 
            IPlayGroundBuilder builder2 = new PlayGroundBuilder2();

            //construct PlayGround (product)
            gameEngine.construct(builder1);

            PlayGround playGround1 = builder1.GetResult();
            playGround1.Show("PlayGround1");

            //construct PlayGround (product)
            gameEngine.construct(builder2);

            PlayGround playGround2 = builder2.GetResult();
            playGround2.Show("PlayGround2");
        }
    }
}