namespace StrategyGame.Model.Heroes
{
    public class Peasant : IHero
    {
        public int Hitpoints { get; set; }
        public int Damage { get; set; }
        public int Speed { get; set; }
    }
}
