using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    //�Լ� ����� ������ �ൿ�ϰ� �ϴ� ��
    //�Լ�����¹�   �Լ��� Ÿ��   �Լ����̸�()
    //3000�������� �׸����� ������Ʈ�� ������� �ڵ��ϼ���.
    //xray�̸��� ����ϴ� �Լ��� ����� �Լ��� �����ϼ���.
    //������Ʈ�� ��ġ�Ͽ����� ���̵� �ش��ϴ� �̸��� ����ϴ� �Լ�
    public int id = 0; // 1~3

    string[] mname = new string[] { "Xray-100", "Xray-200", "Xray-300"};

    int count = 0;

    int sum(int a, int b)
    {
        return a + b;
    }

    string Getname()
    {
        return "ȫ�浿";
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
