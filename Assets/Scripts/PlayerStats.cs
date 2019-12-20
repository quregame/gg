using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using stats;

public class PlayerStats : MonoBehaviour
{
    public Stats stats = new Stats(1, 1, 1);
    public static bool death;
    public static int pointstat = 0;
    public float curHP;

    void Start()
    {
        death = false;
        stats.newhp();
        curHP = stats.HP;
    }

    void Update()
    {
        if (curHP > stats.HP)
        {
            curHP = stats.HP;
        }
        if (curHP <= 0)
        {
            curHP = 0;
            death = true;
        }

        GameObject.Find("hpvalue").GetComponent<Text>().text = (stats.vitality).ToString();
        GameObject.Find("defvalue").GetComponent<Text>().text = (stats.defense).ToString();
        GameObject.Find("sharpvalue").GetComponent<Text>().text = (stats.sharpness).ToString();
    }

}
