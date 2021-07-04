using System.Collections;
using System.Collections.Generic;
using UnityEngine;


///<summary>
///伤害检测
///</summary>
public class DamageArea : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        PlayerController pc = other.GetComponent<PlayerController>();
        if (pc != null)
        {
            pc.ChangeHealth(-1);
        }
    }

}
