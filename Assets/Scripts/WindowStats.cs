using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WindowStats : MonoBehaviour
{
    public Button acc;
    public Button inchp, incdef, incsharp;

    public void close()
    {
        gameObject.SetActive(false);
        WinButtons.statsopen = false;
        if (LevelManager.f1endlevel == false)
        {
            LevelManager.unlocked_levels += 1;
            LevelManager.f1endlevel = true;
        }
    }

    public void upvit()
    {
        if (PlayerStats.statspoints > 0)
        {
            PlayerStats.vitality += 1;
            PlayerStats.statspoints -= 1;
            PlayerStats.newhp();
        }
    }

    public void updef()
    {
        if (PlayerStats.statspoints > 0)
        {
            PlayerStats.defense += 1;
            PlayerStats.statspoints -= 1;
            PlayerStats.newdef();
        }
    }

    public void upsharp()
    {
        if (PlayerStats.statspoints > 0)
        {
            PlayerStats.sharpness += 1;
            PlayerStats.statspoints -= 1;
            PlayerStats.newdmg();
        }
    }

    public void Update()
    {
        if (PlayerStats.statspoints == 0)
        {
            inchp.GetComponent<Button>().interactable = false;
            incdef.GetComponent<Button>().interactable = false;
            incsharp.GetComponent<Button>().interactable = false;
        }
    }
}
