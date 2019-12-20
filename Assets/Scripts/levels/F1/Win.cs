using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public GameObject DialogWindow, WinWindow;
    [SerializeField]
    Sprite stars0;
    [SerializeField]
    Sprite stars1;
    [SerializeField]
    Sprite stars2;
    [SerializeField]
    Sprite stars3;

    public void Start()
    {
        WinWindow.gameObject.SetActive(false);
    }
    public void Update()
    {
        if (DialogWindow.GetComponent<Dialog>().levelisend == true)
        {
            if (DialogWindow.GetComponent<Dialog>().f1stars == 0)
            {
                WinWindow.gameObject.SetActive(true);
                WinWindow.GetComponent<Image>().sprite = stars0;
                GameObject.Find("WinWindow/itog").GetComponent<Text>().text = "Ты, конечно, прошёл уровень, но мог бы и лучше :с";
            }
            else if (DialogWindow.GetComponent<Dialog>().f1stars == 1)
            {
                WinWindow.gameObject.SetActive(true);
                WinWindow.GetComponent<Image>().sprite = stars1;
                GameObject.Find("WinWindow/itog").GetComponent<Text>().text = "Ты прошёл уровень. Ни хорошо, ни плохо, просто прошёл.";
            }
            else if (DialogWindow.GetComponent<Dialog>().f1stars == 2)
            {
                WinWindow.gameObject.SetActive(true);
                WinWindow.GetComponent<Image>().sprite = stars2;
                GameObject.Find("WinWindow/itog").GetComponent<Text>().text = "Ты почти справился, но почти не считается.";
            }
            else if (DialogWindow.GetComponent<Dialog>().f1stars == 3)
            {
                WinWindow.gameObject.SetActive(true);
                WinWindow.GetComponent<Image>().sprite = stars3;
                GameObject.Find("WinWindow/itog").GetComponent<Text>().text = "Вот это да. Ты безупречно прошёл уровень с:";
            }
        }
    }
}
