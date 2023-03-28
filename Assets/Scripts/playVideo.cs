using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
public class playVideo : MonoBehaviour
{
    public VideoPlayer player;
    public float videoFrame;
    public GameObject over;
    void Start()
    {
        videoFrame=player.frameCount;
    }

    void Update()
    {
        
        Debug.Log(player.frame);
        //获取视频当前帧并与总帧数对比
        if (player.frame == videoFrame-1)
        {
            over.SetActive(true);
        }
    }

}
