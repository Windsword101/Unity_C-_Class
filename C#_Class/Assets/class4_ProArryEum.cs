using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Season
{ 
    Spring,Summer,Fall,Winter
}

public enum State
{ 
   Idel,Walk,Attack,Damage,Skill,Dead


}



public class class4_ProArryEum : MonoBehaviour
{
    public Ship ship;

    //一般欄位
    public string name1 = "KID";
    public string name2 = "KID01";
    public string name3 = "KID02";

    //陣列:類型[]
    //屬性面板上的size為數量
    //屬性面板的element為陣列成員 編號從始
    public string[] name;                    //宣告陣列不指定數量

    public float[] weight = new float[3];    //宣告陣列指定數量

    public int[] scoes = new int[] { 20, 30, 40, 50 }; //宣告陣列並指定內容

    public bool[] mission = { true, false, true };  //宣告陣列並指定內容
    private void Start()
    {


        //設定屬性
        ship.length = 99.9f;
        //取得屬性
        print("船的長度:" + ship.length);

        //設定唯獨屬性
        //ship.width=20.5f;//錯誤
        //取得唯獨屬性
        print("船的寬度:" + ship.width);

        ship.atk = 50.3f;
        print("船的攻擊力:" + ship.atk);

        ship.def = 50.5f;
        print("船的防禦力:" + ship.def);

        //指定數列資料
        name = new string[] { "怪物A", "怪物B", "怪物C" };

        //陣列[標號} -注意標號從0開始
        //陣列存放
        scoes[0] = 77;
        //陣列取得
        print("取得怪物陣列第三筆資料:" + name[2]);
        //陣列.Length 為陣列的數量
        print("取得分數陣列的長度(數量):" + scoes.Length);




    }

    //陣列為參考型類別

    private void Changescore(int[] theArray)
    {
        theArray[1] = 99;
    }

    //整數為實質類別
    public int A = 99;

    public int[] B = { 99 };

    private void TestValue(int test)
    {
        test = 0;
    }

    private void TestRefe(int[] test)
    {
        test[0] = 0;
    }





}
