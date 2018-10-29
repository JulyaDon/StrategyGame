using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using StrategyGame.Annotations;
using StrategyGame.Model;
using StrategyGame.Model.Heroes;

namespace StrategyGame.ViewModel
{
    class MainVM : INotifyPropertyChanged
    {
        private string _test = "D:/Users/July/Documents/Visual Studio 2015/Projects/StrategyGame/StrategyGame/View/ImagesAsteriod.png";

        public string Test
        {
            get
            {
                return _test;
            }
            set
            {
                _test = value;
            }
        }

        private AbstractHero archer;
        public ObservableCollection<AbstractHero> Archers { get; set; }
        public MainVM()
        {
            archer  = new Archer("../View/Images/Asteriod.png", 300, 175);
            MoveLeft = new Command(MoveHeroLeft, CanMoveLeft);
            MoveRight = new Command(MoveHeroRight, CanMoveRight);
            Archers = new ObservableCollection<AbstractHero>();
            Archers.Add(archer);
        }
        public ICommand MoveLeft { get; set; }
        public ICommand MoveRight { get; set; }
        /// <summary>
        /// method moves hero left
        /// </summary>
        /// <param name="param"></param>
        private void MoveHeroLeft(object param)
        {
            archer.X -= 10;
        }
        /// <summary>
        /// method moves hero right
        /// </summary>
        /// <param name="param"></param>
        private void MoveHeroRight(object param)
        {
            archer.X += 10;
        }
        private bool CanMoveLeft(object param)
        {
            return archer.X > 0;
        }

        private bool CanMoveRight(object param)
        {
           //TODO: make general canvas
           return archer.X + archer.Width < 525;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged( string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}
