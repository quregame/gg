using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class prologue_script : MonoBehaviour
{
    public GameObject prologue;
    public int count = 1;

    [SerializeField]
    Sprite pr1;
    [SerializeField]
    Sprite pr2;
    [SerializeField]
    Sprite pr3;
    [SerializeField]
    Sprite pr4;
    [SerializeField]
    Sprite pr5;
    [SerializeField]
    Sprite pr6;
    [SerializeField]
    Sprite pr7;
    [SerializeField]
    Sprite pr8;
    
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0) == true && count == 1)
        {
            prologue.GetComponent<Image>().sprite = pr2;
            count++;
            return;
        }

        if (Input.GetMouseButtonUp(0) == true && count == 2)
        {
            prologue.GetComponent<Image>().sprite = pr3;
            count++;
            return;
        }

        if (Input.GetMouseButtonUp(0) == true && count == 3)
        {
            prologue.GetComponent<Image>().sprite = pr4;
            count++;
            return;
        }

        if (Input.GetMouseButtonUp(0) == true && count == 4)
        {
            prologue.GetComponent<Image>().sprite = pr5;
            count++;
            return;
        }

        if (Input.GetMouseButtonUp(0) == true && count == 5)
        {
            prologue.GetComponent<Image>().sprite = pr6;
            count++;
            return;
        }

        if (Input.GetMouseButtonUp(0) == true && count == 6)
        {
            prologue.GetComponent<Image>().sprite = pr7;
            count++;
            return;
        }

        if (Input.GetMouseButtonUp(0) == true && count == 7)
        {
            prologue.GetComponent<Image>().sprite = pr8;
            count++;
            return;
        }

        if (Input.GetMouseButtonUp(0) == true && count == 8)
        {
            SceneManager.LoadScene("map");
        }
    }
}
