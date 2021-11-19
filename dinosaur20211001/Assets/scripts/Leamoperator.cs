using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 1.指定 =
/// 2.數學 + - */ % 遞增 ++ 遞減 - - += -= *= /= %=
/// 3.比較 ><>=<= == !==
/// 4.邏輯 並且&& 或者 || 顛倒!
/// </summary>
public class Leamoperator : MonoBehaviour
{
    #region 指定運算子
    //指定運算子特性
    //指定運算子先執行右邊在指定左邊
    //1+2=3
    public int number = 10; //將數字10指定給欄位 number

    public float numberA = 3;
    public float numberB = 10;
    public int   numberC = 30;
    public int   numberD = 5;

    private int numberE = 9;
    private int numberF = 1;
    #endregion

    public bool boolA = true;
    public bool boolB = false;
    private void Start()

    {
        
        #region 數學運算子
        print("加法" + (numberA + numberB));
        print("減法" + (numberA + numberB));
        print("乘法" + (numberA + numberB));
        print("除法" + (numberA + numberB));
        print("餘數" + (numberA + numberB));

        numberC = numberC = 1;
        print("numberC減1:" + numberC);
        numberC -- ;                       //速減
        print("numberC 減1:" + numberC);

        numberD = numberD + 10;
        print("numberD 加1:" + numberD);
        numberD += 10;                     //遞增指定 + - * / %   
        print("numberD 加1:" + numberD);
        #endregion

        #region 比較運算子
        // 作用 : 比較兩個值，並且取得布林值結果
        print("E > F :" + (numberE > numberF));    //t
        print("E < F :" + (numberE < numberF));    //f
        print("E >=F :" + (numberE >= numberF));   //t
        print("E <= F :" + (numberE <= numberF));  //f
        print("E == F :" + (numberE == numberF));  //f
        print("E != F :" + (numberE != numberF));  //t
        #endregion

        #region 邏輯運算子
        //作用: 比較兩個布林值，並且取得布林值結果
        //並且: 只要有一個false 結果為 false
        print("T && T :" + (true && true));       // t
        print("T && F :" + (true && true));       // f
        print("F && T :" + (false && true));      // f
        print("F && F :" + (false && false));     // f
        //或者: 只要有一個true 結果為true
        print("T || T :" + (true || true));       // t
        print("T || F :" + (true || true));       // t
        print("F || T :" + (false || true));      // t
        print("F || F :" + (false || false));     // f
        // 顛倒!
        // 作用: 將布林值給為相反
        print("!true : " + (!true));               //f
        print("!false : " + (!false));             //t
        #endregion
    }
}
