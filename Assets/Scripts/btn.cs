﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn : MonoBehaviour {
    public GameObject settings;

    public void NewGame()
    {
        //GetComponent<AudioSource>().Play();
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel(1);
#pragma warning restore CS0618 // Type or member is obsolete
     // GameObject.DontDestroyOnLoad(gameObject);
    }

    public void Settings()
    {
        
        settings.SetActive(!settings.activeSelf);
    }

    public void ExitGame()
    {
       
        Application.Quit();
    }

    public void setMusic(float value)
    {
        Global.music = value;
    }

    public void setSound(float value)
    {
        Global.sound = value;
    }
}