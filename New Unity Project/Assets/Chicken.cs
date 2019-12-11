using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    #region 欄位區域
    // Start is called before the first frame update
    [Header ("G8雞基本資料"),Tooltip ("Call me G8"),Range (1,100)]
    public int speed = 10;
    public float turn = 20.5f;
    public string _Name = "G8雞";
    public bool mission;
    #endregion

    public Transform tran;
    public Rigidbody rig;
    public Animator ani;
    public Animation ania;
    

    private void Update()
    {
        Turn();
        Run();
    }

    #region 方法區域
    /// <summary>
    /// 跑步
    /// </summary>
    private void Run()
    {
        float v = Input.GetAxis("Vertical");
        rig.AddForce(tran.forward * speed * v);
    }
    /// <summary>
    /// 旋轉
    /// </summary>
    private void Turn()
    {
        float h = Input.GetAxis("Horizontal");
        tran.Rotate(0, turn*h, 0);
    }
    /// <summary>
    /// 啼叫
    /// </summary>
    private void Burk()
    {

    }
    /// <summary>
    /// 抓取
    /// </summary>
    private void Catch()
    {

    }
    /// <summary>
    /// 任務
    /// </summary>
    private void Task()
    {

    }
    #endregion 
}
