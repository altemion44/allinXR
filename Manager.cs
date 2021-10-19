using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public int score = 0;


    public void Setscore() //점수를 10점 더한다.
    {
        score += 10;
    }

    void Mouseclick_object()
    {
        if (Input.GetMouseButtonDown(0) == true) //왼쪽 마우스 버튼을 클릭하면
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //화면에  ray를 구함

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) == true) //ray로 충돌된 물체 정보를 가져옴
            {
                Debug.Log(hit.transform.name);


                if(hit.transform.GetComponent<Randomtest>().rotatevalue != 0 )
                {
                    Setscore();
                    hit.transform.GetComponent<Randomtest>().Initobject();
                }
                else
                {
                    score -= 10;
                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mouseclick_object();
    }
}
