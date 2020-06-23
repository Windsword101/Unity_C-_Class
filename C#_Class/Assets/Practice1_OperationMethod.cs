using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class Practice1_OperationMethod : MonoBehaviour
{
    //儲存兩數字
    public string number1;
    public string number2;

    [Header("文字:輸出結果")]
    public Text result;

    public void Number1(string number)
    {
        number1 = number;
    }
    public void Number2(string number)
    {
        number2 = number;
    }


    ///<summary>///
    ///定義加法
    ///</summary>///
    public void Add()
    {
        int n1 = Int32.Parse( number1);

        int n2 = Int32.Parse( number2);

        print ("加法結果="+(n1 + n2));
        result.text = ("加法結果=" + (n1 + n2));

    }

    ///<summary>///
    ///定義減法
    ///</summary>///

    public void sub()
    {
        int n1 = Int32.Parse(number1);

        int n2 = Int32.Parse(number2);

        print("減法結果=" + (n1 - n2));

        result.text = ("減法結果=" + (n1 - n2));
    }
    ///<summary>///
    ///定義乘法
    ///</summary>///
    public void mul()
    {
        int n1 = Int32.Parse(number1);

        int n2 = Int32.Parse(number2);

        print("乘法結果=" + (n1 * n2));
        
        result.text = ("乘法結果=" + (n1 * n2));


    }
    ///<summary>///
    ///定義除法
    ///</summary>///
    public void div()
    {
        int n1 = Int32.Parse(number1);

        int n2 = Int32.Parse(number2);

        print("除法結果=" + (n1 / n2));

        result.text = ("除法結果=" + (n1 / n2));
    }

    ///<summary>///
    ///定義餘數
    ///</summary>///
    public void rem()
    {
        int n1 = Int32.Parse(number1);

        int n2 = Int32.Parse(number2);

        print("餘數結果=" + (n1 % n2));


        ///運算結果顯示

        result.text = ("餘法結果=" + (n1 % n2));
        


    }



}

// Update is called once per frame


