using UnityEngine;     //Unity api(函式庫:屬性 ,功能...)

public class class1 : MonoBehaviour
{
    //定義類別成員
    //C#
    //1.大小不一樣
    //2括號成對出現() {} [] '' " " <>

    [Header("car1")]
    public CAR car1;
    [Header("car2")]
    public CAR car2;
    //事件:在特定時間會已指定次數執行的方法(名稱為藍色)
    //開始事件:播放遊戲時執行一次- 初始設定
    private void Start()
    {
        //輸出("輸出文字")
        //C# 解尾為分號;
        print("hellow 0.0");

        //取得與設定欄位
        //取得get
        print("car1的CC數:"+car1.cc);
        print("car2的品牌:" + car2.brand);
        //設定 set
    }  
}
