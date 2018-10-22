using System.ComponentModel;
using System.Runtime.CompilerServices;
using StrategyGame.Annotations;

namespace StrategyGame.Model.Heroes
{
    public class Swordsman : IHero
    {
        public int Hitpoints {
            get { return Hitpoints; }
            set
            {
                Hitpoints = value;
                OnPropertyChanged(nameof(Hitpoints));
            }
        }
        public int MinDamage { get; }
        public int MaxDamage { get; }
        public int Speed { get; }

        public Swordsman()
        {
            Hitpoints = 25;
            MinDamage = 2;
            MaxDamage = 3;
            Speed = 3;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
