using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leampropertystatic : MonoBehaviour
{
    private void Start()
    {
        //靜態屬性
        //取得 get
        //語法:類別名稱.靜態屬性名稱
        print("隨機值:" + Random.value);
        print("所有攝影機數量:" + Camera.allCamerasCount);
        //設定 set - 不能對 red only 屬性設定
        //語法:類別名稱,靜態屬性名稱
        Time.timeScale = 0.5f;
        Cursor.visible = false;

        //random value = 0.5f;   //read only 不能設定

    }
}

