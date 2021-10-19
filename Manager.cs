using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public int score = 0;


    public void Setscore() //������ 10�� ���Ѵ�.
    {
        score += 10;
    }

    void Mouseclick_object()
    {
        if (Input.GetMouseButtonDown(0) == true) //���� ���콺 ��ư�� Ŭ���ϸ�
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //ȭ�鿡  ray�� ����

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) == true) //ray�� �浹�� ��ü ������ ������
            {
                Debug.Log(hit.transform.name);


                if(hit.transform.GetComponent<Randomtest>().rotatevalue != 0 )
                {
                    Setscore();
                    hit.transform.GetComponent<Randomtest>().Initobject();
                }
                else
                {
                    score -= 10;
                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mouseclick_object();
    }
}
