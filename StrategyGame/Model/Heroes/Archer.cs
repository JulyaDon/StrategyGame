using System.ComponentModel;
using System.Runtime.CompilerServices;
using StrategyGame.Annotations;

namespace StrategyGame.Model.Heroes
{
    public class Archer : IHero
    {
        private int _hitpoints;
        public int Hitpoints
        {
            get { return _hitpoints;}
            set
            {
                _hitpoints = value;
                OnPropertyChanged(nameof(Hitpoints));
            }
        }

        public int MinDamage { get; }

        public int MaxDamage { get; }
        public int Speed { get; }
        public Archer()
        {
            _hitpoints = 15;
            MinDamage = 2;
            MaxDamage = 4;
            Speed = 5;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged( string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
