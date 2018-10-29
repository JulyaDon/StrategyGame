using System.ComponentModel;
using System.Runtime.CompilerServices;
using StrategyGame.Annotations;

namespace StrategyGame.Model.Heroes
{
    public class Peasant : AbstractHero
    {
        public Peasant(string image, int x, int y)
        {
            HitPoints = 10;
            MinDamage = 1;
            MaxDamage = 2;
            Speed = 2;
            this.imageURL = image;
            this.x = x;
            this.y = y;
            this.width = 32;
            this.height = 32;
        }
    }
}
