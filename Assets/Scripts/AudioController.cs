using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//使用静态类生成实例,管理游戏音频
public class AudioController : MonoBehaviour
{
    public static AudioController instance;
    public AudioSource audioSource;
    [SerializeField] private AudioClip leftAudio, rightAudio;
    private void Awake()
    {
        instance = this;
    }

    public void PlayAudio(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }
    public void LeftAudio()
    {
        audioSource.clip = leftAudio;
        audioSource.Play();
    }

    public void RightAudio()
    {
        audioSource.clip = rightAudio;
        audioSource.Play();
    }
}
