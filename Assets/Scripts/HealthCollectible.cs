using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        RubyController rubyController=collision.GetComponent<RubyController>();
        //当前出发检测的游戏物体对象身上是否有RubyController脚本
        if(rubyController!=null)
        {
            //有脚本
            //Ruby是否满血
            if(rubyController.Health<rubyController.maxHealth)
            {
                //不满血
                rubyController.ChangeHealth(1);
                Destroy(gameObject);
            }
            
        }
    }
}
