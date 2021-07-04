﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// npc交互相关
/// </summary>

public class NPCmanager : MonoBehaviour
{
    public GameObject tipImage;//按键提示
    public GameObject dialogImage;//对话
    public float showTime = 4;//对话框显示时间
    private float showTimer;//对话框显示计时器
    // Start is called before the first frame update
    void Start()
    {
        tipImage.SetActive(true);//初始默认显示提示键
        dialogImage.SetActive(false);//初始默认显示对话框
        showTimer = -1;
    }

    // Update is called once per frame
    void Update()
    {
        if (showTimer < 0)
        {
            tipImage.SetActive(true);
            dialogImage.SetActive(false);
        }
    }
    /// <summary>
    /// 显示对话框
    /// </summary>
    public void ShowDialog()
    {
        showTimer = showTime;
        tipImage.SetActive(false);
        dialogImage.SetActive(true);
    }

}
