using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * STUDENT NAME: TANAY KAPOOR
 * STUDENT ID: 3011044399
 * DESCRIPTION: THIS IS THE HERO DATA CONTAINER CLASS.
 * 
 */
namespace COMP123_S2019_FinalTestA.Objects
{
    class Hero
    {
        public string HeroName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Pysical Abilities
        public string Fighting { get; set; }
        public string strength { get; set; }
        public string Agility { get; set; }
        public string Endurance { get; set; }
        
        //Mental Abilities
        public string Reason { get; set; }
        public string Intuition { get; set; }
        public string Psyche { get; set; }
        public string Popularity { get; set; }
        public string Name { get; set; }

        //Power List
        List<Power> Powers;

        //Constructor
        Hero()
        {
            // instantiates an empty Power List
            Powers = new List<Power>();
        }

    }
}
