using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinButtons : MonoBehaviour
{
    public Button rest, upst, tomap;
    public GameObject StatsWindow;
    public void restart()
    {
        SceneManager.LoadScene("F1");
    }

    public void upstats()
    {
        StatsWindow.gameObject.SetActive(true);
    }

    public void toomap()
    {
        if (LevelManager.f1endlevel == false)
        {
            LevelManager.unlocked_levels += 1;
            LevelManager.f1endlevel = true;
            SceneManager.LoadScene("map");
        }
        else
        {
            SceneManager.LoadScene("map");
        }
    }
}
