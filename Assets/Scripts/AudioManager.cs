using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 播放音乐音效
/// </summary>
public class AudioManager : MonoBehaviour
{
    public static AudioManager instance
    {
        get; private set;
    }
    private AudioSource audioS;
    // Use this initialization
    void Start()
    {
        instance = this;
        audioS = GetComponent<AudioSource>();
    }
    /// <summary>
    /// 播放指定音效
    /// </summary>
    /// <param name="clip"></param>

    public void AudioPlay(AudioClip clip)
    {
        audioS.PlayOneShot(clip);
    }

}