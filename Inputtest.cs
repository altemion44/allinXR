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


        //키보드입력
        /*
        if( Input.anyKeyDown == true )
        {
            Debug.Log("키가 눌러졌어요!!!");
        }

        if (Input.anyKey == true)
        {
            Debug.Log("키가 눌러졌어요!!!");
        }
        
        if (Input.GetKey(KeyCode.LeftArrow)==true )
        {
            Debug.Log("왼쪽 화살표키 누름");
        }

        //스페이스바를 누르고있으면 큐브가 회전하는 코드를 작성하세요.

        if( Input.GetKey(KeyCode.Space)==true)
        {
            this.transform.Rotate(0f, 1f, 0f);
        }

        //키보드 A키를 누르면 큐브의 스케일이 0.1로 줄어들게하고
        //S키를 누르면 큐브의 스케이이 1로 되도록 코드를 작성하세요.

        if( Input.GetKeyDown(KeyCode.A)==true)
        {
            this.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        }

        if (Input.GetKeyDown(KeyCode.S) == true)
        {
            this.transform.localScale = new Vector3(1f, 1f, 1f);
        }

        //왼쪽 화살표키를 누르면 왼쪽으로 이동
        //오른쪽 화살표키는 오른쪽이동
        //위 화살표키는 전진
        //아래 화살표키는 후진

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
