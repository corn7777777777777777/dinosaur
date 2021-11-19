using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 認識判斷式(條件式)
/// </summary>

public class Leamcondition : MonoBehaviour
{
    public bool OPENDOOR;
    public int SCORE = 70;
    public string weapon = "刀子";
    //開始遊戲: 播放遊戲執行一次
    private void Start()
    {
        #region 判斷式 if
        // 語法 :
        // 當 布林值 為 TRUE 會執行 IF 的 {}
        // IF (布林值) {程式內容}
        if (true)
        {
            print("認識判斷式 IF");
        }

        // IF (布林值) {程式內容}
        // ELSE {程式內容}
        if (OPENDOOR)
        {
            print("開門!");
        }
        else
        {
            print("關門!");
        }
        #endregion
    }
    //更新事件:約一秒鐘60次(60FPS)
    private void Update()
    {
        print("持續執行");

        #region 判斷式 if
        //否則 如果 else if (布林值) {程式內容} - if下方 else 上方 無數量限制
        //如果 分數 >=60及格
        //如果 分數 >=60 但是 >=40 補考
        //否則 就 不及格
        if (SCORE >= 60)
        {
         print("及格~");

        }
        else if(SCORE>=40)
        {
            print("補考");
        }
        else if (SCORE>=30)
        {
            print("當掉");
        }
        else
        {
            print("不及格");
        }
        #endregion

        #region 判斷式 switch
        //switch(值)
        //(
        //  case "刀子"
        //攻擊力 10
        //break;
        //  case "機關槍"
        //攻擊力 1000
        //break;
        //default:
        //這不是武器
        //break;
        //)

        switch(weapon)
        {
            case "刀子":
                print("攻擊力10");
                break;
            case "機關槍":
                print("攻擊力1000");
                break;
            default:
                print("這不是武器");
                break;
        }
        #endregion
    }
}
