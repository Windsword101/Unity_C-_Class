using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class person : MonoBehaviour
{
    [Header("身高")]
    public float height;
    [Header("體重")]
    public float weight;

    // 定義方法語法:
    // 修飾詞 傳回類型 方法名稱 (參數) {陳述式}
    //void無傳回;當使用方法時不會得到任何回傳資料
    public void talk()
    {

        // gameobject 套用此腳本
        // gameobject.name套用此腳本的物件 的 名稱
        print("嗨，我在說話~我是" + gameObject.name);

    }

    ///summary
    ///計算人體的BMI
    ///summary
    ///returns 計算完的 BMI(return)
    public float BMI()
    {
        //BMI公式
        float result = weight / ((height / 100) * (height / 100));
        //回傳 return
        return result;
    }

    public void walk10()
    {
        print("用時速10公里走路");
        print("走路音效");
    }

    public void walk20()
    {
        print("用時速10公里走路");
        print("走路音效");
    }

    ///參數語法:類型 名稱
    ///<summary>
    ///走路方法
    ///<summary>
    ///<param name="speed">需要以多少速度走路<param>
    public void walk(int speed, string direction = "前方",string sound="趴搭")
{
    print(gameObject.name+"用時速"+speed+"公里走路");
    print("走路音效"+sound);
    print("走路方向"+direction);






}

    //攻擊方法:徒手
    public void Attackwithhand()
    { }
    //攻擊方法:拿武器攻擊，音效
    public void Attackwithweapon()
    { }
    //多載 overload
    //1.相同名稱的方法
    //2.參數數量不同 或者 參數類型不同
    ///<summary>
    ///徒手攻擊
    ///</summary>
    public void Attack()
    {
        print(gameObject.name + "徒手攻擊");
    }
    ///<summary>
    ///使用武器攻擊
    ///</summary>
    ///<param name="weapon">想要使用的武器</param>
    public void Attack(string weapon)
    {
        print(gameObject.name + "用武器:"+ weapon +"攻擊!!!");
        print("攻擊音效");
    }

    //讓unity按鈕button使用方法條件:
    //1.修飾詞為公開 public
    //2.參數數量小於1
    ///<summary>
    ///技能
    ///</summary>
    public void skill()
    {
        print(gameObject.name + "施放技能!!!");
    }

}

