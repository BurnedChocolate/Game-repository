using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        RubyController rubyController=collision.GetComponent<RubyController>();
        //当前出发检测的游戏物体对象身上是否有RubyController脚本
        if(rubyController!=null)
        {
            rubyController.ChangeHealth(-1);
        }
    }
}
