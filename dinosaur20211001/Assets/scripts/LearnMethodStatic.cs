using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �ǲ��R�A��k
/// </summary>
public class LearnMethodStatic:MonoBehaviour
{
    private void Start()
    {
        //�R�A��k
        //�I�s��k
        //�y�k:���O�W��.�R�A��k�W��(�������޼�)
        int rint = Random.Range(1, 3);
        print("�H���I��1�P3:" + rint);
        print("-99�������:" + Mathf.Abs(-99));

    }
}
