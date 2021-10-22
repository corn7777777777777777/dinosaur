using UnityEngine;     //�ޥ�unity �����R�W�Ŷ�:�i�H�ϥΦ��Ŷ��� API

//������
// dino 2021
// class ���O:�@�Ӫ��󪺦W��
// �y�k:���O ���O�W��{���O���e(���O����)}
// �����O�n�b Unity ���ϥΥ����~�� Monobehaviour
// �A���ҬO����X�{ : ()�B[]�B{}�B<>�B''�B""
public class Car : MonoBehaviour
{
    #region ��λy�k�Υ|�j�`������
    // ��� Field : �O�s�U�����������
    // �y�k : �׹��� ������� ���W�� ���w �w�]�� �����Ÿ�
    // *�|�j�`������:
    // ��  �� : �x�s�S���p���I�����t��� - int
    // �B�I�� : �x�s�a���p���I�����t�I�� - float
    // �r  �� : �x�s��r��T            - string
    // ���L�� : �O�P�_ true�Bfalse      - bool
    // * �׹���
    // �p�H : ��L���O����s���B����� private(�w�]��)
    // ���} : ��L���O�i�H�s���B��  �� publiv
    // ����ݩ� Attritube
    // �y�k : [�ݩʦW��(��)]
    // 1. ���D Header(�r��)
    // 2. ���� Tooltip(�r��)
    // 3. �d�� Range(�̤p�ȡB�̤j��) - �ȾA�Ω�ƭ����� int�Bfloat
    [Header("CC ��"), Range(500, 5000)]
    public int cc = 1000;
    [Header("���q"), Range(1, 10)]
    public float weight = 3.5f;
    [Header("�~�P�W��"), Tooltip("�o�O���l���~�P�W��")]
    public string brand = "���h";
    [Header("�O�_���ѵ�")]
    public bool haskywindow = true;
    #endregion

    #region Unity ���������
    // �C��B�V�q(�y��)�B����B�C������B����
    public Color color;
    public Color colorRed = Color.red;
    public Color colorYellow = Color.yellow;
    public Color colorCustom1 = new Color(0, 0, 1);
    public Color colorCustom2 = new Color(1, 0, 1, 0.5f);
    // �V�q 2 ~ 4 Vector2
    public Vector2 v2;
    public Vector2 v2One = Vector2.one;
    public Vector2 v2Right = Vector2.right;
    public Vector2 v2left = Vector2.left;
    public Vector2 v2Costom = new Vector2(1, 2);
    public Vector3 v3Costom = new Vector3(1, 2, 3);
    public Vector4 v4Costom = new Vector4(1, 2, 3, 4);
    //���� Kecode keycode
    public KeyCode keycodeMouseleft = KeyCode.Mouse0;
    public KeyCode keycodeMousejump = KeyCode.Space;
    //�C������ Gameobject
    public GameObject goCamera;
    public GameObject goCar;
    //���� Component
    public Transform traCamer;
    public Camera cam;
    public SpriteRenderer spr;
    #endregion

    #region �ƥ�:�{�����J�f
    // �}�l�ƥ�:�C������ɰ���@��
    private void Start()
    {
        // �I�s��k:��k�W��();
        Test();
        Drive80();
        Drive100();
        Drive(120); //�I�s�ɶ�J���٬�:�޼�
        Drive(990);
        float w99 = CovertWeight(9.9f);
        print("9.9 �ഫ:" + w99);

        print("���q�ഫ:" + CovertWeight (weight));
    }
    #endregion

    #region ��k�y�k
    //��k:�O�s�{�����e���ϰ�B�t��k�B���z��
    //�y�k:�׹��� �Ǧ^���� ��k�W��(�Ѽ�1�B�Ѽ�2...) { �{�����e }
    //void �L�Ǧ^:�ϥΤ�k�ɤ��|�Ǧ^���
    //�ۭq��k:���|����B�����I�s�~�|����
    private void Test()
    {
        //��X(�T��)-�N�T����X��Unity ����OConsole
        print("���o�A�U�w:D");



    }
    private void Drive80()
    {
        print("�}���ɳt : " + 80);
        print("����: ������ ");
    }
    private void Drive100()
    {
        print("�}���ɳt : " + 100);
        print("����: ������ ");
    }

    // �Ѽƻy�k:������� �ѼƦW��
    private void Drive(int speed)
    {
        print("�}���ɳt : " + speed);
        print("����: ������ ");
    }

    private float CovertWeight(float setWeight)
    {
        return setWeight * 50;
    }
    #endregion
}
