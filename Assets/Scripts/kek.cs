using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class kek : MonoBehaviour {
    public InputField input;
    // Use this for initialization
    //void Start () {
    //    input = gameObject.GetComponent(typeof(InputField)) as InputField;
    //}
    public void Save()
    {
        //Global.playerName = input.text;
        StreamWriter sw; //= new StreamWriter("PlayerName.txt");
        FileInfo fi = new FileInfo("PlayerName.txt");
        sw = fi.AppendText();
        sw.WriteLine(Global.playerName + "\n\t\t\t\t Score" + Global.pts + "Score");
        sw.Close();

    }
    public void OnSubmit()
    {
        Global.playerName = input.text;
        Debug.Log("suka " + Global.playerName);
        StreamWriter sw; //= new StreamWriter("PlayerName.txt");
        FileInfo fi = new FileInfo("PlayerName.txt");
        sw = fi.AppendText();
        sw.WriteLine(Global.playerName + "\n\t\t\t\t Score" + Global.pts + "Score");
        sw.Close();

    }
}
