using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.EventSystems;
public class btnController : MonoBehaviour
{
    public String btnName;
    public GameObject stopBoard;
    public void returnStart()
    {
        SceneManager.LoadScene(0);
    }
    public void returnChoose()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void gameStart()
    {
        SceneManager.LoadScene(1);
    }
    public void firstLevel()
    {
        SceneManager.LoadScene(2);
    }
    public void secondLevel()
    {
        SceneManager.LoadScene(3);
    }
    public void thirdLevel()
    {
        SceneManager.LoadScene(4);
    }
    public void leftClick()
    {
        AudioController.instance.LeftAudio();
    }
    public void stopGame()
    {
        Time.timeScale = 0;
        Debug.Log("暂停");
        stopBoard.SetActive(true);
    }
    public void continueGame()
    {
        Time.timeScale = 1;
        Debug.Log("继续");
        stopBoard.SetActive(false);
    }
    public void again()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
    }
    public void rightClick()
    {
        AudioController.instance.RightAudio();
    }
    //鼠标按下按钮事件
    public void mouseDown()
    {
        //获取当前按下的按钮名字
        btnName = EventSystem.current.currentSelectedGameObject.name;
    }
    //鼠标抬起按钮事件
    public void mouseUp()
    {
        btnName = null;
        Debug.Log(btnName);
    }
}
