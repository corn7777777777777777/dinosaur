using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �ǲ߰}�Carray
/// </summary>

public class Leamarray : MonoBehaviour
{
    #region �}�C
    //�T�ӹD�㪺����: 100 200 300
    public int priceA = 100;
    public int priceB = 200;
    public int priceC = 300;

    //�}�C�S��: �x�s�ۦP�������
    //�y�k
    //�׹��� ������� [] �}�C�W�� ���w �� �F
    public int[] pricese;

    //�}�C��l��
    //�Ĥ@��:���w�}�C�ƶq
    public int[] scores = new int[5];
    // �ĤG��:���w�}�C��
    public string[] props = { "����", "�Ť�", "����" };

    public int[] levels = new int[10];

    private void Start()
    {
        //���o�}�C��� get
        //�y�k: �}�C�W��[�s��] - �s���q�s�}�l
        print("�ĤT���D��" + props[2]);
        //�]�w�}�C��� set
        //�y�k: �}�C�W��[�s��] ���w �� ;
        props[1] = "�_��";
        print("�ĤG���D��:" + props[1]);

        //�}�C���ƶq
        print("���Ű}�C���ƶq:");

        for(int i = 0; i <10; i++)
        {
            levels[i] = (i + 1);
        }
    }
    #endregion
}
