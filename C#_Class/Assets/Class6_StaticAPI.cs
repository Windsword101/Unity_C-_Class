using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class6_StaticAPI : MonoBehaviour
{
    public Enemy zombie1, zombie2;
    private void Start()
    {
        //一般欄位
        //取得方式:物件.欄位
        print(zombie1.name + "血量:" + zombie1.hp);

        print(zombie2.name + "血量:" + zombie2.hp);


        //靜態欄位
        //取得方式:類別.靜態欄位
        print("殭屍速度:" + Enemy.speed);

        zombie1.Walk();
        zombie2.Walk();

        Enemy.Stop();

        Cursor.visible = false;

        print(Mathf.PI);

        print("物件塗層");
        //取得 隨機. 值
        print(Random.value);

        print("隨機整數" + Random.Range(1, 3));
    } 
    //偵測玩家輸入 -約60FPS
    private void Update()
    {
        //原本用法:字串
        print("玩家是否按空白鍵:");




    }
}
