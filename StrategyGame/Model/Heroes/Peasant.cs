using System.ComponentModel;
using System.Runtime.CompilerServices;
using StrategyGame.Annotations;

namespace StrategyGame.Model.Heroes
{
    public class Peasant : IHero
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
       
        public Peasant()
        {
            Hitpoints = 10;
            MinDamage = 1;
            MaxDamage = 2;
            Speed = 2;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
