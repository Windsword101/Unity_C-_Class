using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    //公開欄位:給任何人存取
    //從其他類別取得或存放資料
    public float speed = 20;
    //私人欄位:僅限於此類存取
    //從其他類別無法取得或存放資料
    private float weight = 50;

    //問題:
    //假設需要取但是不能修改 - 屬性(權限)
    //屬性語法
    //修飾詞 類型 名稱 {存取權限}
    //get可以取得
    //set可以存放
    //讀寫權限屬性
    public float length { get; set; }

    //企劃:寬度固定30不便
    //封裝欄位
    //1. 私人欄位
    //2. 唯獨屬性(return 私人欄位)
    private float _width = 30;
    //唯獨屬性:不能設定值
    public float width { get { return _width; } }

    private float _height;

    //=> (黏巴達 lambda)
    // C#6板以上| unity 2017 C# 7版
    // C#改版 8 版
    // get=> _height; 等同於 { get { return _height; } }
    public float height { get => _height; }

    private float Lv = 3;

    /// <summary>
    /// 企劃攻擊力等於等級*攻擊力
    /// </summary>
    private float _atk;
    public float atk { get { return _atk; }set { _atk = value * Lv; } }

    private float _def;
    public float def { get => _def;set=> _def=value*Lv; }
}
