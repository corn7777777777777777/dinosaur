using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leampropertystatic : MonoBehaviour
{
    private void Start()
    {
        //�R�A�ݩ�
        //���o get
        //�y�k:���O�W��.�R�A�ݩʦW��
        print("�H����:" + Random.value);
        print("�Ҧ���v���ƶq:" + Camera.allCamerasCount);
        //�]�w set - ����� red only �ݩʳ]�w
        //�y�k:���O�W��,�R�A�ݩʦW��
        Time.timeScale = 0.5f;
        Cursor.visible = false;

        //random value = 0.5f;   //read only ����]�w

    }
}

