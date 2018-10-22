using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyGame.Model.Heroes
{
    public interface IHero : INotifyPropertyChanged
    {
        int Hitpoints { get; set; }
        int MinDamage { get; }
        int MaxDamage { get; }
        int Speed { get; }
    }
}
