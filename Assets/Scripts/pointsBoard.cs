using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pointsBoard : MonoBehaviour
{
    [SerializeField] private GameObject lHit,rHit;
    [SerializeField] private GameObject border;
    [SerializeField] private Text successNum;
    [SerializeField] private Text failNum;
    [SerializeField] private Text leftNum;
    [SerializeField] private Text rightNum;
    [SerializeField] private Text finalSuccessNum;
    [SerializeField] private GameObject gameOver;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //成功数目=左边成功数目+右边成功数目
        successNum.text = (lHit.GetComponent<hitController>().successNum+rHit.GetComponent<hitController>().successNum).ToString();
        failNum.text = border.GetComponent<border>().failNum.ToString();
        leftNum.text = lHit.GetComponent<hitController>().leftNum.ToString();
        rightNum.text = rHit.GetComponent<hitController>().rightNum.ToString();
        //判断hierarchy面板中是否还存在tag为normal的球
        if (GameObject.FindWithTag("normal")==null)
        {
            gameOver.SetActive(true);
            
            finalSuccessNum.text = successNum.text;
        }
    }
}
