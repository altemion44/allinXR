using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Hello : MonoBehaviour
{
    int data1 = 0;
    int data2 = 2;
    int data3 = 2;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(data2 != data3);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
