using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toMap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            SceneManager.LoadScene("Map");
        }
        if (Input.GetMouseButtonDown(1) == true)
        {
            SceneManager.LoadScene("Map");
        }
    }
}
