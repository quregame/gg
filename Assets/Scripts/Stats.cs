using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace stats
{
    public class Stats : MonoBehaviour
    {
        public float HP;
        public float ATK;
        public float DEF;
        public int vitality = 1;
        public int defense = 1;
        public int sharpness = 1;
        public int minATK = 2;
        public int maxATK = 5;
        public int minDMG;
        public int maxDMG;

        public Stats()
        {
            newdmg();
            newhp();
            newdef();
        }

        public Stats(int vitality, int defense, int sharpness)
        {
            this.vitality = vitality;
            this.defense = defense;
            this.sharpness = sharpness;
            newdmg();
            newhp();
            newdef();
        }


        public void newdmg()
        {
            minDMG = minATK * (this.sharpness + 100) / 50;
            maxDMG = maxATK * (this.sharpness + 100) / 50;
        }

        public void newhp()
        {
            HP = Mathf.Floor(this.vitality * 21.6f);
        }

        public void newdef()
        {
            DEF = Mathf.Floor(this.defense * 3.8f);
        }
    }
}
    
