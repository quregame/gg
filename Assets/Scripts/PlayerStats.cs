using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public static float HP;
    public static float DEF;
    public static int vitality = 1;
    public static int defense = 1;
    public static int sharpness = 1;
    public static int minATK = 2;
    public static int maxATK = 5;
    public static int minDMG;
    public static int maxDMG;
    public static float curHP;
    public static bool death;
    public static int statspoints = 0;

    public void Start()
    {
        newhp();
        newdmg();
        newdef();
        curHP = HP;
        death = false;
    }

    public static void newdmg()
    {
        minDMG = minATK * (sharpness + 100) / 50;
        maxDMG = maxATK * (sharpness + 100) / 50;
    }

    public static void newhp()
    {
        HP = Mathf.Floor(vitality * 21.6f);
        curHP = HP;
    }

    public static void newdef()
    {
        DEF = Mathf.Floor(defense * 3.8f);
    }

    public void Update()
    {
        if (curHP > HP)
        {
            curHP = HP;
        }
        if (curHP <= 0)
        {
            curHP = 0;
            death = true;
        }

        if (WinButtons.statsopen == true)
        {
            GameObject.Find("hpvalue").GetComponent<Text>().text = (vitality).ToString();
            GameObject.Find("defvalue").GetComponent<Text>().text = (defense).ToString();
            GameObject.Find("sharpvalue").GetComponent<Text>().text = (sharpness).ToString();
            GameObject.Find("pointtitle").GetComponent<Text>().text = "Осталось очков: " + (statspoints).ToString();
        }
    }
}
    
