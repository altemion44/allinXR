using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifecycle : MonoBehaviour
{
    void Awake() //��ü�� �ʱ�ȭ�� ����ȣ��, ������ Ư������ �ʱ�ȭ�Ҷ� ���
    {
        Debug.Log("Awake ����!!!");
    }

    void OnEnable()  //��ü�� Ȱ��ȭ �ɶ� ȣ��Ǵ� �Լ�
    {
        Debug.Log("�Ⱥ����� ����!!!");
    }

    void Start()    //��ũ��Ʈ�� Ȱ��ȭ �Ǵ� ���� ��ó�� ȣ��
    {
        Debug.Log("Start ����!!!");
    }

    void Update()   //�������Ӹ��� ȣ��
    {
        //Debug.Log("Update!!");
    }

    void FixedUpdate()  //���������� ������ �ѹ� ���� ����Ǵ� �Լ�(0.02�ʸ��� ȣ��)
    {
        //Debug.Log("Fixedupdate!!");
    }

    void LateUpdate()   //���� ��� ������Ʈ�� ������ ȣ��(ī�޶��̵��� �ַ� ���)
    {
        //Debug.Log("LateUpdate");
    }

    void OnDisable()  //������Ʈ�� ��Ȱ��ȭ �ɶ� ȣ��
    {
        Debug.Log("������Ʈ�� ��Ȱ��ȭ");
    }

    void OnDestroy()   //���ӿ�����Ʈ�� �����ɶ� ȣ��
    {
        Debug.Log("������Ʈ ����!!!!");
    }

}
