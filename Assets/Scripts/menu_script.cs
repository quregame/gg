using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu_script : MonoBehaviour
{
    public int sound;
    public GameObject button_sound;
    
    [SerializeField]
    Sprite sound_on;
    [SerializeField]
    Sprite sound_off;
    
    public void NewGame()
    {
        SceneManager.LoadScene("pr1");
    }

    public void ToggleSound()
    {
        if (sound == 1)
        {
            AudioListener.volume = 0;
            sound = 0;
        }
        else if (sound == 0)
        {
            AudioListener.volume = 1;
            sound = 1;
        }
    }

    void Start()
    {
        sound = 1;
    }

    void Update()
    {
        if (sound == 1)
        {
            button_sound.GetComponent<Image>().sprite = sound_on;
        }
        else if(sound == 0)
        {
            button_sound.GetComponent<Image>().sprite = sound_off;
        }
    }
}
