using UnityEngine;
public class Class2_operator : MonoBehaviour
{
    public float  a = 10;
    public float  b = 3;
    public string c = "7";
    public int    d = 3;
    public int    e = 99;
    public int    f = 9;
    public bool   g = true;
    public bool   h = false;
    public int key;
    public int result;
    public int hp = 100;
    // Start;開始事件 - 播放遊戲時執行時播方一次
    void Start()

    {
        #region 數學運算子
        //數學運算子:加減乘除餘+-*/%
        print(a + b);     //13
        print(a - b);     //7
        print(a * b);     //30
        print(a / b);     //3.3333333
        print(a % b);     //-1

        //加法: 串接字串與其他資料 - 其結果為字串
        print("分數:" + 99.9f);
        //將字串與數直接將不會運算視為新的字串
        #endregion

        #region 比較運算子
        //比較運算子:
        //大於.小於.小於大於.等於小於.等於等於.不等於
        // >.<. <= =< == !=    
        print(e>f);        //T
        print(e<f);        //F
        print(e<=f);       //T
        print(e>=f);       //F
        print(e==f);       //F
        print(e!=f);       //T
        #endregion

        #region 邏輯運算子
        //邏輯運算子:結果為布林值 - 比較兩個布林值
        //並且&& 只要有個 false -shift - 7
        print(("並且") + (g&&h));
        //或者||只要有個為true - shift - 鎮
        print(("或者") + (g || h));
        print(true && true);          //T
        print(true && false);         //F
        print(true && false);         //F
        print(false && false);        //F

        print(true || true);          //T
        print(true || false);         //T
        print(true || false);         //T
        print(false || false);        //F
        #endregion

        #region 顛倒運算子
        //顛倒運算子:加在布林值 - 將布林值改為顛倒的結果
        print(!true);
        print(!false);
        #endregion

        //指定運算子 = 右邊先運算在指定給左邊
        result = 2 + 3 ;
        print(result);

        key = key + 1;
        print("鑰匙:" + key);

        //後置遞增++:先輸出再遞增
        print("鑰匙數量:"+ key++);
        //前置遞增++:先遞增再輸出
        print("鑰匙數量:" + ++key);

        //指派運算子: += -= *= /= %=
        //HP=hp+20
        hp += 30;
        print("血量" + hp);//120
        //hp=hp - 50
        hp -= 50;
        print("血量:"+hp);//70

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
