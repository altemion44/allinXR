using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iftest : MonoBehaviour
{
    int level = 10; //사용자의 레벨
    int age = 20;
    string gender = "female";


    string id = "AAA";
    string pw = "aaa";

    int type = 3; // 1~5번까지 

    // Start is called before the first frame update
    void Start()
    {
        /*

        switch(gender)
        {
            case "male":
                Debug.Log("남성 사용자입니다.");
                break;
            case "female":
                Debug.Log("여성 사용자입니다.");
                break;
        }

        switch(type)
        {
            case 1:
                Debug.Log("1번을 선택하셨습니다.");
                break;
            case 2:
                Debug.Log("2번을 선택하셨습니다.");
                break;
            case 3:
                Debug.Log("3번을 선택하셨습니다.");
                break;
            case 4:
                Debug.Log("4번을 선택하셨습니다.");
                break;

            defalt:
                Debug.Log("5번을 선택하셨습니다.");
                break;

        }
        */

        /*
       if(level < 10)  //레벨이 10보다 작으면 이스크립트가 들어있는 오브젝트를 안보이게 해라.
       {
           this.gameObject.SetActive(false);
       }


       if(id != "AAA" || pw != "AAA" )
       {
           Debug.Log("아이디 패스워드를 확인하세요");
       }
       if( id=="AAA" && pw=="AAA")
       {
           Debug.Log("로그인 되었습니다.");
       }
       */



        /*
        if (age < 18)
        {
            Debug.Log("이앱을 사용할 수 없습니다.");
        }
        else
        {
            
            if ( gender == "male")
            {
                Debug.Log("안녕하세요. 반갑습니다.");
            }
            else
            {
                Debug.Log("안녕하세요. 또오셨네요. 반갑습니다.");
            }

        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
