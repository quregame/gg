using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class map_script : MonoBehaviour
{
    public void Forest_level_1()
    {
        SceneManager.LoadScene("Forest_level_1");
    }

    public void Desert_level_1()
    {
        SceneManager.LoadScene("Desert_level_1");
    }

    public void Swamp_level_1()
    {
        SceneManager.LoadScene("Swamp_level_1");
    }

    public void Jungle_level_1()
    {
        SceneManager.LoadScene("Jungle_level_1");
    }

    public void Winter_level_1()
    {
        SceneManager.LoadScene("Winter_level_1");
    }

    void Start()
    {

    }

}

