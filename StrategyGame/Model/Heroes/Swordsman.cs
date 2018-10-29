using System.ComponentModel;
using System.Runtime.CompilerServices;
using StrategyGame.Annotations;

namespace StrategyGame.Model.Heroes
{
    public class Swordsman : AbstractHero
    {
        public Swordsman(string image, int x, int y)
        {
            HitPoints = 25;
            MinDamage = 2;
            MaxDamage = 3;
            Speed = 3;
            this.imageURL = image;
            this.x = x;
            this.y = y;
            this.width = 32;
            this.height = 32;
        }
    }
}
