using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    float s = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.localScale = new Vector3(s, s, s);
    }

    // Update is called once per frame
    void Update()
    {
        if(s < 3f)
        {
            s += 0.01f;
            if(s>3f)
            {
                s = 3f;
            }
            this.transform.localScale = new Vector3(s, s, s);
        }
        else
        {
            this.transform.Rotate(0f, 0.1f, 0f);
        }
        
    }
}
