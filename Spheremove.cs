using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spheremove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
         ======�浹üũ�� ������=======
         1. �浹�� ������ ������Ʈ���� �� rigidbody������Ʈ�� �ʿ���
         2. �浹������ ������Ʈ�� �ε����� ������Ʈ�� �ݶ��̴��� �ʿ���
         3  �浹 ������ ������Ʈ�� ��ũ��Ʈ�� �ʿ���.
         4. �浹������ ���� �浹���� �Լ��� �־����.
             OnCollisionEnter,OnCollisionExit,OnCollisionStay
          
         * */

        //Sphere�� ������ٵ��� addforece�� Ȱ���Ͽ� �̵�
        this.GetComponent<Rigidbody>().AddForce(-300f, 0f, 0f);
    }


    //�������� �浹�� �Ͼ���� �浹�� ó�� �����Ǵ� �����ӿ��� �ѹ� ȣ��
    private void OnCollisionEnter(Collision collision) //collision ������ �浹�� ������ ����
    {
        Debug.Log("�浹����  :  " + collision.transform.name);
        
        //��ü�� �̸����� üũ
        if(collision.gameObject.name == "Cube") //�浹�� ��ü�� �̸��� Cube�̸�
        {
            Destroy(collision.gameObject);  //�浹�� ��ü�� ����
            this.GetComponent<Rigidbody>().AddForce(-300f, 0f, 0f); //�������� �����༭ �̵�
        }

        //���ӿ�����Ʈ�� Tag���� �̿��Ͽ� üũ
        if(collision.gameObject.tag=="Cube") //�浹�� ��ü�� tag�� cube�� 
        {
            Destroy(collision.gameObject);  //�浹�� ��ü�� ����
            this.GetComponent<Rigidbody>().AddForce(-300f, 0f, 0f); //�������� �����༭ �̵�
        }
    }

    //�������� �浹�� ������ �ι�ü�� ��������  �����ӿ��� �ѹ� ȣ��
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("�浹��  :  " + collision.transform.name);
    }


    //�������� �浹�� �Ͼ �ι�ü�� �浹�ǰ������� ȣ��
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("�浹��  :  " + collision.transform.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
