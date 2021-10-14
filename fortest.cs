using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fortest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;

        for(i = 1; i < 1001; i++)
        {
            Debug.Log(" i : " + i);
        }

        Debug.Log("반복문 끝");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
