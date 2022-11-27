using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //玩家输入监听
        float horizontal = Input.GetAxis("Horizontal");
        float vertical =Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        //Ruby的水平、垂直方向移动
        position.x = position.x + 5 * horizontal * Time.deltaTime;
        position.y = position.y + 5 * vertical* Time.deltaTime;
        transform.position = position;
    }
}
