using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    //함수 명령을 내려서 행동하게 하는 것
    //함수만드는법   함수의 타입   함수의이름()
    //3000프레임을 그린다음 오브젝트가 사라지게 코딩하세요.
    //xray이름을 출력하는 함수를 만들고 함수를 실행하세요.
    //오브젝트를 터치하였을때 아이디에 해당하는 이름을 출력하는 함수
    public int id = 0; // 1~3

    string[] mname = new string[] { "Xray-100", "Xray-200", "Xray-300"};

    int count = 0;

    int sum(int a, int b)
    {
        return a + b;
    }

    string Getname()
    {
        return "홍길동";
    }

    void Touch_showname()
    {
        if(id!=0 && id<4)
        {
            Debug.Log(mname[id - 1]);
        }
        
    }

    void Show_mname()
    {
        for(int i = 0; i<mname.Length; i++)
        {
            Debug.Log(mname[i]);
        }
    }

    void Hideobject()
    {
        this.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        Touch_showname();
    }

    // Update is called once per frame
    void Update()
    {
       

    }
}
