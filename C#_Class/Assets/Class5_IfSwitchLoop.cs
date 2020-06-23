using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class5_IfSwitchLoop : MonoBehaviour
{
    [Header("是否開門")]
    public bool opendoor;
    [Header("分數")]
    public int score = 0;
    [Header("血量"), Range(0, 100)]
    public int Hp = 0;
    [Header("道具")]
    public string prop = "紅水";

    public string test;

    private int i = 1;
    private int j = 1;

    private void Awake()
    {
        //while迴圈
        //while(布林值)(當布林值回TRUE執行)
  

        while (i <= 10)

        {
            print("while 迴圈第:"+i+"次");
            i++;
        }

        //迴圈之後評估:第一次判斷 j=2
        do
        {
            print("while 迴圈第:" + j + "次");
            j++;
        } while (j<=10);

        //for(初始值;條件;迭代器)

        for (int k = 1; k <= 10; k++)
        {
            print("for迴圈數:" + k + "次");  
        }
        for (int k = 10; k > 0; k--)
        {
            print("迴圈倒數" + k+"次");
        }








    }



    // Start is called before the first frame update
    private void Start()
    {
        //if判斷式
        //if(布林值){布林值=true時執行}
        if (true)
        {
            print("哈摟,我是if判斷式~");
        }
    }
    // Update is called once per frame
    private void Update()
    {

        switch(prop)
        {
            case "紅水":
                print("補 Hp~");
                break;
            case "藍水":
                print("補 Mp~");
                break;
            case "黃水":
                print("補 Exp~");
                break;
            default:
                print("你吃錯道具哦~");
                break;
        }
         

        if (opendoor)
        {
            print("開門~");
        }
        else
        {
            print("關門~");
        }
        



        if ( score >=60)
        {
            print("及格");
        }

        else if (score < 60)
        {
            print("不及格");
        }

        else if (score >= 40)
        {
            print("補考");
        }

        else 
        {
            print("當掉");
        }

        if (Hp>=70)
            {
                print("安全");
            }

            else if (Hp<=20)
            {
                print("危險");
            }

            else
            {
                print("警告");
            }







    }

}
