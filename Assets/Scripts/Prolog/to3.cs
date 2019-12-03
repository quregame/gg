using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class to3 : MonoBehaviour
{
    GameObject Prolog_music;
    void Awake()
    {
        DontDestroyOnLoad(Prolog_music);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "pr2" || scene.name == "pr3" || scene.name == "pr4" || scene.name == "pr5" || scene.name == "pr6" || scene.name == "pr7" || scene.name == "pr8")
            AudioListener.volume = 1;
        else
            AudioListener.volume = 0;
    }

    void Destroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            SceneManager.LoadScene("pr3");
        }
        if (Input.GetMouseButtonDown(1) == true)
        {
            SceneManager.LoadScene("pr3");
        }
    }
}
