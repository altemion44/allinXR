using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spheremove1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().AddForce(-300f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    //�浹 ��ü�� �ݶ��̴��� is trigger �ɼ��� Ȱ��ȭ �� �����̸� �Ʒ� �Լ�ȣ��

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ʈ���� �浹 : " + other.transform.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Ʈ���� �浹 : " + other.transform.name);
    }

    private void OnTriggerStay(Collider other)
    {
        
    }
}
