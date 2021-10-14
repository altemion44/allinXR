using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fortest : MonoBehaviour
{
    string[] mname = new string[] { "Xray-1", "Xray-2", "Xray-3", "Xray-5", "Xray-6" };
    int[] count = new int[] { 1, 2, 3, 4, 5 };
    int[] gender = new int[] { 1, 2, 1, 1, 2, 2, 1 };
        
    string[,] mnamelv = new string[,]
    {
        { "Xray-1", "Xray-2", "Xray-3", "Xray-5", "Xray-6" },
        { "Xray-10", "Xray-20", "Xray-30", "Xray-50", "Xray-60" },
        { "Xray-100", "Xray-200", "Xray-300", "Xray-500", "Xray-600" },
    };




    // Start is called before the first frame update
    void Start()
    {
        /*
        //반복문 종류 : for , foreach , while, do~while

        for(int i = 0;i<100;i++)
        {
            //특정한 조건에 반복문을 끝내는 명령
            if(i==50)
            {
                break;
            }

            //특정한 조건에 반복문을 끝내는 명령
            if (i%2==1) //홀수
            {
                continue;
            }

            Debug.Log(i);
        }
        

        
         * 
         
        int i = 10;

        do
        {
            Debug.Log(i);
            i++;
        } while (i < 5);

        
       int i = 0;

       while( i < 5 )
       {
           Debug.Log(i);
           i++;
       }

       for(int i = 0;i<5;i++)
       {
           Debug.Log(i);
       }


      foreach(int temp in gender )
      {
          if(temp==1)
          {
              Debug.Log("남성입니다.");
          }
          else if(temp==2)
          {
              Debug.Log("여성입니다.");
          }
      }


     foreach(string temp in mname)
     {
         Debug.Log(temp);
     }




     for (int i = 0;i<3;i++)
     {
         for(int j = 0;j<5;j++)
         {
             Debug.Log("레벨 " + (i + 1) + "장비 : " + mnamelv[i, j]);
         }
     }



     //구구단 출력문제 
     for(int i = 2; i< 10; i++)
     {
         for(int j = 1; j<10;j++)
         {
             Debug.Log(i + "x" + j + "=" + (i * j));
         }
     }



     for(int i = 0; i< mname.Length ;i++ )
     {
         Debug.Log(mname[i]);
     }
     */


        //배열에 있는 xray이름을 모두 화면에 출력하세요.

        /*

        for(int i = 1; i < 1001; i++)
        {
            Debug.Log(" i : " + i);
        }

        Debug.Log("반복문 끝");
        

        int result = 0;

        for (int i = 1; i<=100; i++)
        {
            result = result + i;
        }

        Debug.Log("1부터 100까지의 합은 " + result);
        */

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
