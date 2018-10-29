using System.ComponentModel;
using System.Runtime.CompilerServices;
using StrategyGame.Annotations;

namespace StrategyGame.Model.Heroes
{
    public class Archer : AbstractHero
    {
        public Archer(string image, int x, int y)
        {
            HitPoints = 15;
            MinDamage = 2;
            MaxDamage = 4;
            Speed = 5;
            this.imageURL = image;
            this.x = x;
            this.y = y;
            this.width = 32;
            this.height = 32;
        }
    }
}
