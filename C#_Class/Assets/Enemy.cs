﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    // 一般欄位(非靜態)屬於物件
    public float hp;

    //屬於靜態欄位
    public static float speed=3;

    public void Walk()
    {
        print(name = "走路中...");

    }

    //靜態方法
    //靜態方法只能存取靜態成員
    public static void Stop()
    {
        speed = 0;
        print("所有怪物的速度"+speed);


    }





   
}
