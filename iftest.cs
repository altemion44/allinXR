using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iftest : MonoBehaviour
{
    int level = 10; //������� ����
    int age = 20;
    string gender = "female";


    string id = "AAA";
    string pw = "aaa";

    int type = 3; // 1~5������ 

    // Start is called before the first frame update
    void Start()
    {
        /*

        switch(gender)
        {
            case "male":
                Debug.Log("���� ������Դϴ�.");
                break;
            case "female":
                Debug.Log("���� ������Դϴ�.");
                break;
        }

        switch(type)
        {
            case 1:
                Debug.Log("1���� �����ϼ̽��ϴ�.");
                break;
            case 2:
                Debug.Log("2���� �����ϼ̽��ϴ�.");
                break;
            case 3:
                Debug.Log("3���� �����ϼ̽��ϴ�.");
                break;
            case 4:
                Debug.Log("4���� �����ϼ̽��ϴ�.");
                break;

            defalt:
                Debug.Log("5���� �����ϼ̽��ϴ�.");
                break;

        }
        */

        /*
       if(level < 10)  //������ 10���� ������ �̽�ũ��Ʈ�� ����ִ� ������Ʈ�� �Ⱥ��̰� �ض�.
       {
           this.gameObject.SetActive(false);
       }


       if(id != "AAA" || pw != "AAA" )
       {
           Debug.Log("���̵� �н����带 Ȯ���ϼ���");
       }
       if( id=="AAA" && pw=="AAA")
       {
           Debug.Log("�α��� �Ǿ����ϴ�.");
       }
       */



        /*
        if (age < 18)
        {
            Debug.Log("�̾��� ����� �� �����ϴ�.");
        }
        else
        {
            
            if ( gender == "male")
            {
                Debug.Log("�ȳ��ϼ���. �ݰ����ϴ�.");
            }
            else
            {
                Debug.Log("�ȳ��ϼ���. �ǿ��̳׿�. �ݰ����ϴ�.");
            }

        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
