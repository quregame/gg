using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void Forest_level_1()
    {
        SceneManager.LoadScene("F1");
    }

    public void Desert_level_1()
    {
        SceneManager.LoadScene("D1");
    }

    public void Swamp_level_1()
    {
        SceneManager.LoadScene("S1");
    }

    public void Jungle_level_1()
    {
        SceneManager.LoadScene("J1");
    }

    public void Winter_level_1()
    {
        SceneManager.LoadScene("W1");
    }
}
