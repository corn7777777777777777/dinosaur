using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �ǲ߫D�R�A�ݩ�
/// </summary>
public class LearnProperty : MonoBehaviour
{
    //�D�R�A�ݩʨϥΤ覡
    //1.�w�q�@����� : �Ω��x�s���骫��
    //2.��������������P�Q�s�����D�R�A�ݩ����O�ۦP
    //3.��쥲���s�����骫��(�N����즲����줺)
    public Transform traA;
    public Camera camA;
    private void Start()
    {
        //���oGet
        //�y�k:���W��.�D�R�A�ݩʦW��
        print("A ���󪺮y�� : " + traA.position);
        print("A ��v�����`��: " + camA.depth);
        //�]�w set
        //�y�k: ���W��.�D�R�A�ݩʦW�� ���w �ȡF
        camA.depth = 9.9f;
        traA.position = new Vector3(-7, 3);
    }
}
