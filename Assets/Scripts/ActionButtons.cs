using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionButtons : MonoBehaviour
{
    public Button PhysicalAttack, Heal, DefenseAction;
    public static Animator animplayer;
    public void PhysicalAttackb()
    {
        animplayer.SetBool("Attack", true);
    }

    public void Healb()
    {
        PlayerStats.curHP += (PlayerStats.vitality * 2.65f);
        animplayer.SetBool("Attack", false);
        animplayer.SetBool("Heal", true);
    }



    void Start()
    {
        if (Dialog.haveaheal == true)
        {
            Heal.GetComponent<Button>().interactable = true;
        }
        else
        {
            Heal.GetComponent<Button>().interactable = false;
        }

        DefenseAction.GetComponent<Button>().interactable = false;

        animplayer = GameObject.Find("playerUnit").GetComponent<Animator>();
    }

    void Update()
    {
        
    }
}
