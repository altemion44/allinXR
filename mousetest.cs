using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousetest : MonoBehaviour
{
    public float s = 1f;
    public bool object_rotate = true;
    public bool object_scale = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Mousescale()
    {
        float ps = Input.GetAxis("Mouse ScrollWheel");
        
        if(ps!=0)
        {
            Debug.Log(ps);
        }

        s = s + ps;

        if(s <= 0.2f)  //�������� 0.2 �̸����� �۾����� �ʰ�
        {
            s = 0.2f;
        }

        this.transform.localScale = new Vector3(s, s, s);
    }

    void Mouserotate()  //���콺�� Ŭ���Ͽ� ������Ʈ�� ȸ����Ű�� �ڵ�
    {
        if(Input.GetMouseButton(0)==true)
        {
            this.transform.Rotate(0f, 1f, 0f);
        }

        if (Input.GetMouseButton(1) == true)
        {
            this.transform.Rotate(0f, -1f, 0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(object_rotate==true)
        {
            Mouserotate();
        }

        if(object_scale==true)
        {
            Mousescale();
        }
        
        

        

        //0:���ʹ�ư  1:�����ʹ�ư  2:��  3~~ :

        /*
        if (Input.GetMouseButton(1) == true) //���콺 ��ư�� ��� ������������ üũ
        {
           
        }

        if (Input.GetMouseButtonDown(1) == true) //���콺��ư ���ö� �ѹ��� üũ
        {
           
        }

        if (Input.GetMouseButtonUp(1) == true) //���콺 ��ư�� ���� üũ
        {
           
        }
        */
    }
}