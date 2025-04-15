using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsProject
{
    internal class GameManager
    {
        public enum RoundChoices
        {
            BestOfOne,
            BestOfThree,
            BestOfFive
        }

        private RoundChoices roundChoice;


        public RoundChoices RoundType { get { return roundChoice; } set { roundChoice = value; } }



    }
}
