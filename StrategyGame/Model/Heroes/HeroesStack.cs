using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyGame.Model.Heroes
{
    public class HeroesStack<T> where T : AbstractHero
    {
        private Stack<T> _heroesStack = new Stack<T>();

        public void Attack()
        {

        }
    }
}
