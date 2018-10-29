using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using StrategyGame.Annotations;

namespace StrategyGame.Model.Heroes
{
    public abstract class AbstractHero : INotifyPropertyChanged
    {
        private int _hitpoints;
        protected int x;
        protected int y;
        protected int width;
        protected int height;
        protected string imageURL;
        public event PropertyChangedEventHandler PropertyChanged;
        public int HitPoints
        {
            get
            {
                return _hitpoints;
            }
            set
            {
                _hitpoints = value;
                OnPropertyChanged(nameof(HitPoints));
            }
        }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int Speed { get; set; }
        /// <summary>
        /// X - coordinate of the object
        /// </summary>
        public int X
        {
            get { return x; }
            set
            {
                x = value;
                OnPropertyChanged(nameof(X));
                OnPropertyChanged("Margin");
            }
        }

        /// <summary>
        /// Y - coordinate of the object
        /// </summary>
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
                OnPropertyChanged(nameof(Y));
                OnPropertyChanged("Margin");
            }
        }
        /// <summary>
        /// Width of the craft.
        /// </summary>
        public int Width {
            get
            {
                return width;
            }
        }

        /// <summary>
        /// Height of the craft
        /// </summary>
        public int Height {
            get
            {
                return height;
            }
        }

        /// <summary>
        /// Path to the sprite of the object
        /// </summary>
        public string ImageSouce { get { return imageURL; } }
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
