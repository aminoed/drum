using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class hitController : MonoBehaviour
{
    private GameObject btnControl;
    public string hitName;
    public int successNum, leftNum, rightNum;
    private void Start()
    {
        btnControl = GameObject.Find("buttonManager");
    }

    private void Update()
    {
        hitName = btnControl.GetComponent<btnController>().btnName;
    }

    //进入trigger范围内
    private void OnTriggerStay2D(Collider2D other)
    {
        //左边的锣
        //通关对比按下的按钮名与触发的物体tag是否相同来判断是否正确
        if (gameObject.tag == "left" && hitName == "left")
        {
            if (other.CompareTag("normal"))
            {
                // Debug.Log(gameObject.tag + "成功按到" + other.tag);
                successNum++;
                leftNum++;
            }
            Destroy(other.gameObject);
        }
        //右边的鼓鼓
        if (gameObject.tag == "right" && hitName == "right")
        {
            if (other.CompareTag("normal"))
            {
                // Debug.Log(gameObject.tag + "成功按到" + other.tag);
                successNum++;
                rightNum++;
            }
            Destroy(other.gameObject);
        }
    }
}
