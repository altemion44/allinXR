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
        //��ü�� y���� �������� ȸ���ϰ� �ۼ��غ�����.
        //this.transform.rotation = Quaternion.Euler(0f, y , 0f);

        //this.transform.Rotate(0f, speed, 0f);

        //Ư�� Ÿ���� �ٶ󺸰� �ϴ� ȸ��
        this.transform.LookAt(target);
    }
}
