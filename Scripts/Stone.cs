using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Stone : MonoBehaviour
{
    private bool canBeForce;
    private bool isOnhill;
    public int forceNum;
    public double hight;
    // Start is called before the first frame update
    void Start()
    {
        this.canBeForce = true;
        this.isOnhill = false;
        this.hight = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
       if (canBeForce)
        {
            //添加推力，区分是否在坡上
            Vector3 pushForce = new Vector3(0, 0, forceNum);
            if (this.isOnhill)
            {
                pushForce = new Vector3(0, forceNum, forceNum);//依照45度坡推动
            }
            //处理交互事件
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log(pushForce);
                //推动石头
                GetComponent<Rigidbody>().AddForce(pushForce, ForceMode.Impulse);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //到达底部后切换是否在坡上状态
        if (other.CompareTag("hilldown"))
        {
            isOnhill = !isOnhill;
        }
        Debug.Log(other.name+" "+isOnhill);
    }
}
