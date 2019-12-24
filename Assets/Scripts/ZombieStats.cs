using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZombieStats : MonoBehaviour
{
    public static float HP;
    public static float DEF;
    public static int vitality = 4;
    public static int defense = 3;
    public static int sharpness = 3;
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

    public void OnTriggerEnter(Collider attzomb)
    {
        float dmg = Random.Range(PlayerStats.minDMG, PlayerStats.maxDMG);
        if (attzomb.gameObject.name == "playerUnit")
        {
            ActionButtons.animplayer.SetBool("Attack", false);
            curHP = curHP - dmg;
        }
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
            SceneManager.LoadScene("map");
        }
    }
}
