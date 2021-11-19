using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 學習非靜態屬性
/// </summary>
public class LearnProperty : MonoBehaviour
{
    //非靜態屬性使用方式
    //1.定義一個欄位 : 用於儲存實體物件
    //2.欄位資料類型必須與想存取的非靜態屬性類別相同
    //3.欄位必須存放到實體物件(將物件拖曳至欄位內)
    public Transform traA;
    public Camera camA;
    private void Start()
    {
        //取得Get
        //語法:欄位名稱.非靜態屬性名稱
        print("A 物件的座標 : " + traA.position);
        print("A 攝影機的深度: " + camA.depth);
        //設定 set
        //語法: 欄位名稱.非靜態屬性名稱 指定 值；
        camA.depth = 9.9f;
        traA.position = new Vector3(-7, 3);
    }
}
