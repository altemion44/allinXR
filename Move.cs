using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float xspeed = 0f;
    public float yspeed = 0f;
    public float zspeed = 0f;
    public Transform target;  //���� �̵��ؾ��� ������Ʈ�� transform

    void OnEnable()
    {
        //this.transform.position = new Vector3(0f, 0f, 0f);
    }
    // Start is called before the first frame update
    void Start()
    {
        //�����ϸ� ��ǥ�� (0, 5, 0)
        //this.transform.position = new Vector3(0f, 5f, 0f);  //�������̵����
    }

    // Update is called once per frame
    void Update()
    {
        //�������Ӹ��� ���������� �̵�
        //this.transform.position = this.transform.position + new Vector3(xspeed, yspeed, zspeed);
        //this.transform.Translate(xspeed, yspeed, zspeed);


        //��������ġ�� �̵��ϴ� ���
        //this.transform.position = Vector3.MoveTowards(transform.position, target.position, 0.01f);


        //�ε巴�� �����ϸ鼭 �̵�
        //Vector3 velo = Vector3.zero;
        //this.transform.position = Vector3.SmoothDamp(transform.position, target.position, ref velo, 1f);

    }
}
