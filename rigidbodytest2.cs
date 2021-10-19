using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbodytest2 : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)==true)
        {
            rb.AddExplosionForce(3000f, this.transform.position, 20f, 500f);
            //첫번째값:폭발력   두번째값:폭발위치    세번째값:반경       네번째값:위로 폭발하는 힘
        }
    }
}
