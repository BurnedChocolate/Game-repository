using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    //生命值
    public int maxHealth =5;//最大生命值为五
    private int currentHealth;//当前生命值
    public int Health{get{return currentHealth;}}

    //速度
    public int speed=10;

    //无敌时间
    public float timeInvincible = 2.0f;//无敌时间常量
    private bool isInvincible;
    private float invincibleTimer;//计时器

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d=GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        //玩家输入监听
        float horizontal = Input.GetAxis("Horizontal");
        float vertical =Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        //Ruby的水平、垂直方向移动
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical* Time.deltaTime;
        //transform.position = position;
        rigidbody2d.MovePosition(position);

        if(isInvincible)
        {
            invincibleTimer = invincibleTimer - Time.deltaTime;
            if(isinvincibleTimer<=0)
            {
                isInvincible = false;
            }
        }
    }

    public void ChangeHealth(int amount)
    {
        if(amount<0)
        {
            if(isInvincible)
            {
                return;
            }

            //受到伤害
            isInvincible=true;
            isinvincibleTimer = timeInvincible;
        }

        currentHealth = Mathf.Clamp(currentHealth+amount,0,maxHealth);
        Debug.Log(currentHealth+"/"+maxHealth);
    }

}
