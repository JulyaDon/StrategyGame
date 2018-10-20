using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyGame.Model.Heroes
{
    public interface IHero
    {
        int Hitpoints { get; set; }
        int Damage { get; set; }
        int Speed { get; set; }
    }
}
