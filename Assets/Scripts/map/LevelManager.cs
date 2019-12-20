using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static int unlocked_levels = 1;
    public static bool f1endlevel = false;

    [SerializeField]
    Sprite level_av;
    [SerializeField]
    Sprite level_unav;
    [SerializeField]
    Sprite level_acc;
    [SerializeField]
    Sprite level_hover;
    [SerializeField]
    Sprite level_acc_hover;

    public void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (i < unlocked_levels)
            {
                transform.GetChild(i).GetComponent<Image>().sprite = level_av;
                transform.GetChild(i).GetComponent<Button>().interactable = true;
            }
            else
            {
                transform.GetChild(i).GetComponent<Image>().sprite = level_unav;
                transform.GetChild(i).GetComponent<Button>().interactable = false;
            }
        }
    }

    public void Update()
    {
        
    }
}
