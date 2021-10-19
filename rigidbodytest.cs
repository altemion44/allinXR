using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbodytest : MonoBehaviour
{
    public float speed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        bool keycheck = false;

        if(Input.GetKey(KeyCode.LeftArrow)==true)
        {
            keycheck = true;
            this.GetComponent<Rigidbody>().AddForce(-speed, 0f, 0f);
        }

        if(Input.GetKey(KeyCode.RightArrow)==true)
        {
            keycheck = true;
            this.GetComponent<Rigidbody>().AddForce(speed, 0f, 0f);
        }

        if(Input.GetKey(KeyCode.UpArrow)==true)
        {
            keycheck = true;
            this.GetComponent<Rigidbody>().AddForce(0f, 0f, speed);
        }

        if(Input.GetKey(KeyCode.DownArrow)==true)
        {
            keycheck = true;
            this.GetComponent<Rigidbody>().AddForce(0f, 0f, -speed);
        }

        if(keycheck==false) //�ƹ��� Ű�� 
        {
            this.GetComponent<Rigidbody>().velocity = Vector3.zero; //�ӵ����� 0���� �����ؼ� ����
        }
       

    }
}
