﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class to5 : MonoBehaviour
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
            Application.LoadLevel("pr5");
        }
        if (Input.GetMouseButtonDown(1) == true)
        {
            Application.LoadLevel("pr5");
        }
    }
}
