using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputtest : MonoBehaviour
{
    public float speed = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Vector3 pos = new Vector3(x, 0f, z);
        this.transform.Translate(pos);


        //Ű�����Է�
        /*
        if( Input.anyKeyDown == true )
        {
            Debug.Log("Ű�� ���������!!!");
        }

        if (Input.anyKey == true)
        {
            Debug.Log("Ű�� ���������!!!");
        }
        
        if (Input.GetKey(KeyCode.LeftArrow)==true )
        {
            Debug.Log("���� ȭ��ǥŰ ����");
        }

        //�����̽��ٸ� ������������ ť�갡 ȸ���ϴ� �ڵ带 �ۼ��ϼ���.

        if( Input.GetKey(KeyCode.Space)==true)
        {
            this.transform.Rotate(0f, 1f, 0f);
        }

        //Ű���� AŰ�� ������ ť���� �������� 0.1�� �پ����ϰ�
        //SŰ�� ������ ť���� �������� 1�� �ǵ��� �ڵ带 �ۼ��ϼ���.

        if( Input.GetKeyDown(KeyCode.A)==true)
        {
            this.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        }

        if (Input.GetKeyDown(KeyCode.S) == true)
        {
            this.transform.localScale = new Vector3(1f, 1f, 1f);
        }

        //���� ȭ��ǥŰ�� ������ �������� �̵�
        //������ ȭ��ǥŰ�� �������̵�
        //�� ȭ��ǥŰ�� ����
        //�Ʒ� ȭ��ǥŰ�� ����

        if (Input.GetKey(KeyCode.LeftArrow)==true)
        {
            this.transform.Translate(-speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            this.transform.Translate(speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            this.transform.Translate(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            this.transform.Translate(0f, 0f, -speed);
        }
        */


    }
}
