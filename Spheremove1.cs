using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spheremove1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().AddForce(-300f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    //충돌 물체의 콜라이더에 is trigger 옵션이 활성화 된 상태이면 아래 함수호출

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("트리거 충돌 : " + other.transform.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("트리거 충돌 : " + other.transform.name);
    }

    private void OnTriggerStay(Collider other)
    {
        
    }
}
