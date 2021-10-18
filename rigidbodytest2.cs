using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbodytest2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)==true)
        {
            this.GetComponent<Rigidbody>().AddExplosionForce(3000f, this.transform.position, 20f, 500f);
            //첫번째값:폭발력   두번째값:폭발위치    세번째값:반경       네번째값:위로 폭발하는 힘
        }
    }
}
