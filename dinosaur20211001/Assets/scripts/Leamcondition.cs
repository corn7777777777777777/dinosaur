using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �{�ѧP�_��(����)
/// </summary>

public class Leamcondition : MonoBehaviour
{
    public bool OPENDOOR;
    public int SCORE = 70;
    public string weapon = "�M�l";
    //�}�l�C��: ����C������@��
    private void Start()
    {
        #region �P�_�� if
        // �y�k :
        // �� ���L�� �� TRUE �|���� IF �� {}
        // IF (���L��) {�{�����e}
        if (true)
        {
            print("�{�ѧP�_�� IF");
        }

        // IF (���L��) {�{�����e}
        // ELSE {�{�����e}
        if (OPENDOOR)
        {
            print("�}��!");
        }
        else
        {
            print("����!");
        }
        #endregion
    }
    //��s�ƥ�:���@����60��(60FPS)
    private void Update()
    {
        print("�������");

        #region �P�_�� if
        //�_�h �p�G else if (���L��) {�{�����e} - if�U�� else �W�� �L�ƶq����
        //�p�G ���� >=60�ή�
        //�p�G ���� >=60 ���O >=40 �ɦ�
        //�_�h �N ���ή�
        if (SCORE >= 60)
        {
         print("�ή�~");

        }
        else if(SCORE>=40)
        {
            print("�ɦ�");
        }
        else if (SCORE>=30)
        {
            print("��");
        }
        else
        {
            print("���ή�");
        }
        #endregion

        #region �P�_�� switch
        //switch(��)
        //(
        //  case "�M�l"
        //�����O 10
        //break;
        //  case "�����j"
        //�����O 1000
        //break;
        //default:
        //�o���O�Z��
        //break;
        //)

        switch(weapon)
        {
            case "�M�l":
                print("�����O10");
                break;
            case "�����j":
                print("�����O1000");
                break;
            default:
                print("�o���O�Z��");
                break;
        }
        #endregion
    }
}
