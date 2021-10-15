using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifecycle : MonoBehaviour
{
    void Awake() //객체가 초기화된 이후호출, 변수나 특정값을 초기화할때 사용
    {
        Debug.Log("Awake 시작!!!");
    }

    void OnEnable()  //객체가 활성화 될때 호출되는 함수
    {
        Debug.Log("안보였다 보임!!!");
    }

    void Start()    //스크립트가 활성화 되는 순간 맨처음 호출
    {
        Debug.Log("Start 시작!!!");
    }

    void Update()   //매프레임마다 호출
    {
        //Debug.Log("Update!!");
    }

    void FixedUpdate()  //물리엔진이 연산을 한번 한후 실행되는 함수(0.02초마다 호출)
    {
        //Debug.Log("Fixedupdate!!");
    }

    void LateUpdate()   //위의 모든 업데이트가 끝난후 호출(카메라이동시 주로 사용)
    {
        //Debug.Log("LateUpdate");
    }

    void OnDisable()  //오브젝트가 비활성화 될때 호출
    {
        Debug.Log("오브젝트가 비활성화");
    }

    void OnDestroy()   //게임오브젝트가 삭제될때 호출
    {
        Debug.Log("오브젝트 삭제!!!!");
    }

}
