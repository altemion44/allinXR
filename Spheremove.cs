using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spheremove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
         ======충돌체크시 주의점=======
         1. 충돌을 감지할 오브젝트에는 꼭 rigidbody컴포넌트가 필요함
         2. 충돌감지할 오브젝트와 부딪히는 오브젝트에 콜라이더가 필요함
         3  충돌 감지할 오브젝트에 스크립트가 필요함.
         4. 충돌종류에 따른 충돌감지 함수를 넣어야함.
             OnCollisionEnter,OnCollisionExit,OnCollisionStay
          
         * */

        //Sphere를 리지드바디의 addforece를 활용하여 이동
        this.GetComponent<Rigidbody>().AddForce(-300f, 0f, 0f);
    }


    //물리적인 충돌이 일어났을때 충돌이 처음 감지되는 프레임에서 한번 호출
    private void OnCollisionEnter(Collision collision) //collision 변수로 충돌된 정보가 들어옴
    {
        Debug.Log("충돌시작  :  " + collision.transform.name);
        
        //물체의 이름으로 체크
        if(collision.gameObject.name == "Cube") //충돌된 물체의 이름이 Cube이면
        {
            Destroy(collision.gameObject);  //충돌된 물체를 삭제
            this.GetComponent<Rigidbody>().AddForce(-300f, 0f, 0f); //왼쪽으로 힘을줘서 이동
        }

        //게임오브젝트의 Tag값을 이용하여 체크
        if(collision.gameObject.tag=="Cube") //충돌된 물체의 tag가 cube면 
        {
            Destroy(collision.gameObject);  //충돌된 물체를 삭제
            this.GetComponent<Rigidbody>().AddForce(-300f, 0f, 0f); //왼쪽으로 힘을줘서 이동
        }
    }

    //물리적인 충돌이 끝나고 두물체가 떨어지는  프레임에서 한번 호출
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("충돌끝  :  " + collision.transform.name);
    }


    //물리적인 충돌이 일어난 두물체가 충돌되고있으면 호출
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("충돌중  :  " + collision.transform.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
