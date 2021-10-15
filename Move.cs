using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float xspeed = 0f;
    public float yspeed = 0f;
    public float zspeed = 0f;
    public Transform target;  //내가 이동해야할 오브젝트의 transform

    void OnEnable()
    {
        //this.transform.position = new Vector3(0f, 0f, 0f);
    }
    // Start is called before the first frame update
    void Start()
    {
        //시작하면 좌표를 (0, 5, 0)
        //this.transform.position = new Vector3(0f, 5f, 0f);  //포지션이동방법
    }

    // Update is called once per frame
    void Update()
    {
        //매프레임마다 오른쪽으로 이동
        //this.transform.position = this.transform.position + new Vector3(xspeed, yspeed, zspeed);
        //this.transform.Translate(xspeed, yspeed, zspeed);


        //정해진위치로 이동하는 방법
        //this.transform.position = Vector3.MoveTowards(transform.position, target.position, 0.01f);


        //부드럽게 감속하면서 이동
        //Vector3 velo = Vector3.zero;
        //this.transform.position = Vector3.SmoothDamp(transform.position, target.position, ref velo, 1f);

    }
}
