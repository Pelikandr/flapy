using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
public class btn : MonoBehaviour {
    public GameObject settings;
    public InputField input;
    private void Start()
    {
        input = gameObject.GetComponent(typeof(InputField)) as InputField;
        //var textobject : UI.InputField;
    }
    public void NewGame()
    {
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel(2);
#pragma warning restore CS0618 // Type or member is obsolete
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

    public void Save()
    {
        //Global.playerName = input.text;
        StreamWriter sw; //= new StreamWriter("PlayerName.txt");
        FileInfo fi = new FileInfo("PlayerName.txt");
        sw = fi.AppendText();
        sw.WriteLine(Global.playerName + "\n\t\t\t\t Score" + Global.pts + "Score");
        sw.Close();
        
    }
    public void Save2()
    {

    }

    //public void Input()
    //{
    //    //Global.playerName = input.text;
    //}
}
