using UnityEngine;
/// <summary>
/// 控制器:2D 橫向卷軸版本
/// </summary>
public class Controller2D : MonoBehaviour
{
    #region 欄位 公開
    [Header("移動速度"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("跳躍高度"), Range(0, 15000)]
    public float jump = 300;
    [Header("檢查地板尺寸與位移")]
    [Range(0, 1)]
    public float checkGroundRadius = 0.1f;
    public Vector3 checkGroundOffset;
    [Header("跳躍按鍵與可跳躍圖層")]
    public KeyCode keyjump = KeyCode.Space;
    public LayerMask canjumpLayer;

    #endregion

    ///<summary>剛體元件 Rigbody 2D
    ///繪製圖示
    ///在unity 繪製輔助用的圖示
    ///線條、射線、圖形、方型、扇形、圖片
    ///</summary>
    private void OnDrawGizmos()
    {
        ///1.決定圖示顏色
        Gizmos.color = new Color(1, 0, 0.2f, 0.3f);
        ///2.決定繪製圖形
        ///transform.position 此物件的世界座標
        ///transform.TransFormDirection.position()根據變形元件的區域座標轉換為世界座標
        Gizmos.DrawSphere(transform.position +
            transform.TransformDirection(checkGroundOffset), checkGroundRadius);
    }
    ///剛體元件 Rigidbody 2D
    ///</summary>

    private Rigidbody2D rig;

    private void Start()
        ///<summary>Update約60Fps固定更新事件:50FPS處理物理行為
    {
        rig = GetComponent<Rigidbody2D>();
    }

    ///<summary>
    ///Update約 60 FPS
    ///固定更新事件:50 fps
    ///處理物理行為
    ///</summary>
    private void FixedUpdate()

    {
        Move();
    }
    private void Update()
    {
        Flip();
    }
    #region 方法
    ///<summary>
    ///1.玩家是否有按移動按鍵 左右方向 或 A,D 2物件移動
    ///2.物件移動行為(API)
    ///</summary>
    private void Move()
    {
        //h 值 指定為 輸入 .取得軸向(水平軸) - 水平軸代表左右鍵與 AD
        float h = Input.GetAxis("Horizontal");
        print("玩家左右件按鍵值" + h);

        //剛體元件,加速度 = 新 二維向量 (h值 * 移動速度 剛體 加速度 垂直);
        rig.velocity = new Vector2(h * speed, rig.velocity.y);
    }

    
    
    ///<summary>
    ///翻面
    ///左:角度 Y 180
    ///右:角度 Y 0
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

