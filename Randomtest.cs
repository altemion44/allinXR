using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomtest : MonoBehaviour
{
    public int rand;
    public float playtime = 0f;
    public float rotatevalue = 0f;
    // Start is called before the first frame update
    void Start()
    {   
        rand = Random.Range(5, 60);  //0~100������ ���ڸ� �������� �̾��ش�.

        //GameObject.Find("Manager").GetComponent<Manager>().Setscore(); //�Ŵ��� ������Ʈ�� �ִ� �Ŵ�����ũ��Ʈ�� ������ �ø���.
    }

    public void Initobject()
    {
        rand = Random.Range(5, 60);
        rotatevalue = 0;
        playtime = 0;
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        int mainscore = GameObject.Find("Manager").GetComponent<Manager>().score;

        playtime += Time.deltaTime;  //���� �÷���Ÿ���� �˼�����

        if(playtime > rand)
        {
            if(mainscore < 100) 
            {
                this.transform.Rotate(0f, 0.5f, 0f);
                rotatevalue += 0.5f;
            }
            else
            {
                this.transform.Rotate(0f, 1f, 0f);
                rotatevalue += 1f;
            }
            

            if(rotatevalue > 360f)
            {
                Initobject();
            }
        }
    }
}
