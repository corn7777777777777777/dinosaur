using UnityEngine;
/// <summary>
/// ���:2D ��V���b����
/// </summary>
public class Controller2D : MonoBehaviour
{
    #region ��� ���}
    [Header("���ʳt��"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("���D����"), Range(0, 15000)]
    public float jump = 300;
    [Header("�ˬd�a�O�ؤo�P�첾")]
    [Range(0, 1)]
    public float checkGroundRadius = 0.1f;
    public Vector3 checkGroundOffset;
    [Header("���D����P�i���D�ϼh")]
    public KeyCode keyjump = KeyCode.Space;
    public LayerMask canjumpLayer;

    #endregion

    ///<summary>���餸�� Rigbody 2D
    ///ø�s�ϥ�
    ///�bunity ø�s���U�Ϊ��ϥ�
    ///�u���B�g�u�B�ϧΡB�諬�B���ΡB�Ϥ�
    ///</summary>
    private void OnDrawGizmos()
    {
        ///1.�M�w�ϥ��C��
        Gizmos.color = new Color(1, 0, 0.2f, 0.3f);
        ///2.�M�wø�s�ϧ�
        ///transform.position �����󪺥@�ɮy��
        ///transform.TransFormDirection.position()�ھ��ܧΤ��󪺰ϰ�y���ഫ���@�ɮy��
        Gizmos.DrawSphere(transform.position +
            transform.TransformDirection(checkGroundOffset), checkGroundRadius);
    }
    ///���餸�� Rigidbody 2D
    ///</summary>

    private Rigidbody2D rig;

    private void Start()
        ///<summary>Update��60Fps�T�w��s�ƥ�:50FPS�B�z���z�欰
    {
        rig = GetComponent<Rigidbody2D>();
    }

    ///<summary>
    ///Update�� 60 FPS
    ///�T�w��s�ƥ�:50 fps
    ///�B�z���z�欰
    ///</summary>
    private void FixedUpdate()

    {
        Move();
    }
    private void Update()
    {
        Flip();
    }
    #region ��k
    ///<summary>
    ///1.���a�O�_�������ʫ��� ���k��V �� A,D 2���󲾰�
    ///2.���󲾰ʦ欰(API)
    ///</summary>
    private void Move()
    {
        //h �� ���w�� ��J .���o�b�V(�����b) - �����b�N���k��P AD
        float h = Input.GetAxis("Horizontal");
        print("���a���k������" + h);

        //���餸��,�[�t�� = �s �G���V�q (h�� * ���ʳt�� ���� �[�t�� ����);
        rig.velocity = new Vector2(h * speed, rig.velocity.y);
    }

    
    
    ///<summary>
    ///½��
    ///��:���� Y 180
    ///�k:���� Y 0
    ///</summary>
    private void Flip()
    {
        float h = Input.GetAxis("Horizontal");
        //
        if (h < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);

        }
        else if (h > 0)
        {
            transform.eulerAngles = Vector3.zero;
         }
    }


}
    #endregion

