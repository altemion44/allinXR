using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbodytest1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this.GetComponent<Rigidbody>().AddForce(100f, 0f, 0f); //������ǥ�������� ������
        //this.GetComponent<Rigidbody>().AddRelativeForce(100f, 0f, 0f); //������ǥ(��ü�� ��ǥ)�� ������

        this.GetComponent<Rigidbody>().AddForce(200f, 0f, 0f);
        this.GetComponent<Rigidbody>().AddTorque(0f,0f,-90f);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
