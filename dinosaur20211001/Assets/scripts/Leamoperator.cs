using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 1.���w =
/// 2.�ƾ� + - */ % ���W ++ ���� - - += -= *= /= %=
/// 3.��� ><>=<= == !==
/// 4.�޿� �åB&& �Ϊ� || �A��!
/// </summary>
public class Leamoperator : MonoBehaviour
{
    #region ���w�B��l
    //���w�B��l�S��
    //���w�B��l������k��b���w����
    //1+2=3
    public int number = 10; //�N�Ʀr10���w����� number

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
        
        #region �ƾǹB��l
        print("�[�k" + (numberA + numberB));
        print("��k" + (numberA + numberB));
        print("���k" + (numberA + numberB));
        print("���k" + (numberA + numberB));
        print("�l��" + (numberA + numberB));

        numberC = numberC = 1;
        print("numberC��1:" + numberC);
        numberC -- ;                       //�t��
        print("numberC ��1:" + numberC);

        numberD = numberD + 10;
        print("numberD �[1:" + numberD);
        numberD += 10;                     //���W���w + - * / %   
        print("numberD �[1:" + numberD);
        #endregion

        #region ����B��l
        // �@�� : �����ӭȡA�åB���o���L�ȵ��G
        print("E > F :" + (numberE > numberF));    //t
        print("E < F :" + (numberE < numberF));    //f
        print("E >=F :" + (numberE >= numberF));   //t
        print("E <= F :" + (numberE <= numberF));  //f
        print("E == F :" + (numberE == numberF));  //f
        print("E != F :" + (numberE != numberF));  //t
        #endregion

        #region �޿�B��l
        //�@��: �����ӥ��L�ȡA�åB���o���L�ȵ��G
        //�åB: �u�n���@��false ���G�� false
        print("T && T :" + (true && true));       // t
        print("T && F :" + (true && true));       // f
        print("F && T :" + (false && true));      // f
        print("F && F :" + (false && false));     // f
        //�Ϊ�: �u�n���@��true ���G��true
        print("T || T :" + (true || true));       // t
        print("T || F :" + (true || true));       // t
        print("F || T :" + (false || true));      // t
        print("F || F :" + (false || false));     // f
        // �A��!
        // �@��: �N���L�ȵ����ۤ�
        print("!true : " + (!true));               //f
        print("!false : " + (!false));             //t
        #endregion
    }
}
