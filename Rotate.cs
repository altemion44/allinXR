using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 0.1f;
    public Transform target;
    //float y = 0;
    // Start is called before the first frame update
    void Start()
    {
        //this.transform.rotation = Quaternion.Euler(45f, 15f, 23f);
    }

    // Update is called once per frame
    void Update()
    {
        //y += 0.1f;
        //객체가 y축을 기준으로 회전하게 작성해보세요.
        //this.transform.rotation = Quaternion.Euler(0f, y , 0f);

        //this.transform.Rotate(0f, speed, 0f);

        //특정 타겟을 바라보게 하는 회전
        this.transform.LookAt(target);
    }
}
