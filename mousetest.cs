using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousetest : MonoBehaviour
{
    public float s = 1f;
    public bool object_rotate = true;
    public bool object_scale = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Mousescale()
    {
        float ps = Input.GetAxis("Mouse ScrollWheel");
        
        if(ps!=0)
        {
            Debug.Log(ps);
        }

        s = s + ps;

        if(s <= 0.2f)  //스케일이 0.2 미만으로 작아지지 않게
        {
            s = 0.2f;
        }

        this.transform.localScale = new Vector3(s, s, s);
    }

    void Mouserotate()  //마우스로 클릭하여 오브젝트를 회전시키는 코드
    {
        if(Input.GetMouseButton(0)==true)
        {
            this.transform.Rotate(0f, 1f, 0f);
        }

        if (Input.GetMouseButton(1) == true)
        {
            this.transform.Rotate(0f, -1f, 0f);
        }
    }

    void Mouseclick_object()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            Vector3 mpos = Vector3.zero;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) == true)
            {
                Debug.Log(hit.transform.name);  
                Debug.Log(hit.point);

                this.transform.position = hit.point;

                /*
                if (hit.transform.name == "Cube")  //마우스로 클릭한 오브젝트 이름이 Cube면 삭제
                {
                    Destroy(hit.transform.gameObject);
                }
                */
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(object_rotate==true)
        {
            Mouserotate();
        }

        if(object_scale==true)
        {
            Mousescale();
        }

        Mouseclick_object();






        //0:왼쪽버튼  1:오른쪽버튼  2:휠  3~~ :

        /*
        if (Input.GetMouseButton(1) == true) //마우스 버튼을 계속 누르고있으면 체크
        {
           
        }

        if (Input.GetMouseButtonDown(1) == true) //마우스버튼 누늘때 한번만 체크
        {
           
        }

        if (Input.GetMouseButtonUp(1) == true) //마우스 버튼을 뗄때 체크
        {
           
        }
        */
    }
}
