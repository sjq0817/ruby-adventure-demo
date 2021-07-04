using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 控制子弹的移动，碰撞
/// </summary>
public class BulletController : MonoBehaviour
{
    Rigidbody2D rbody;
    public AudioClip hitClip;//命中音效
    // Use this for initialization
    void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, 2f);//消失时间
    }

    // Update is called once per frame
    void Update()
    {

    }
    /// <summary>
    /// 子弹移动
    /// </summary>
    public void Move(Vector2 moveDirection, float moveForce)
    {
        rbody.AddForce(moveDirection * moveForce);
    }
    ///碰撞检测
    void OnCollisionEnter2D(Collision2D other)
     {
        RobotController rc = other.gameObject.GetComponent<RobotController>();
       if (rc != null)
        {
          rc.Fixed();//修复敌人的方法
        }
        AudioManager.instance.AudioPlay(hitClip);//播放命中音效
        Destroy(this.gameObject);
     }
}

