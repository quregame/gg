using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowStats : MonoBehaviour
{
    public Button acc;

    public void close()
    {
        gameObject.SetActive(false);
    }
}
