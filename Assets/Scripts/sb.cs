using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
public class sb : MonoBehaviour
{
    public Text scoreboard;
    public string filename = "";
    public string playerName;
    // Use this for initialization
    void Start()
    {
        filename = "PlayerName.txt";
        scoreboard = gameObject.GetComponent(typeof(Text)) as Text;
       
        
}

    // Update is called once per frame
    void Update()
    {
        int[] arr = new int[20];
        string txt = "";
        StreamReader streamReader = new StreamReader("PlayerName.txt");
        string[] arr1 = new string[20];
        string[] name = new string[50];
        while (!streamReader.EndOfStream)
        {
            txt += streamReader.ReadLine();
            
            //s1 += stemp.Substring(0, stemp.IndexOf("Score"));
            //s2 += stemp.Substring(stemp.IndexOf(":"),stemp.Length);
            //str += streamReader.ReadLine()+" "+"\n";
        }
        streamReader.Close();

        string[] txtArr = txt.Split(new[] { "Score" }, StringSplitOptions.RemoveEmptyEntries);
        int[] pointsTemp = new int[txtArr.Length];

        for (int i = 0; i < txtArr.Length; i++)
        {
            if (i % 2 == 1)
            {
                pointsTemp[i] = Convert.ToInt32(txtArr[i]);
            }
            else
            {
                name[i] = txtArr[i];
                pointsTemp[i] = 999;
            }
        }
        for (int j = 0; j < 20; j++)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == null && i < 17)
                {
                    name[i] = name[i + 1];
                    name[i + 1] = null;
                    if (name[i + 1] != null)
                    {
                        name[i] = name[i + 2];
                    }
                }
            }
        }
        string pointsString="";
        for (int o=0;o<pointsTemp.Length;o++)
        {
            pointsString += Convert.ToString(pointsTemp[o]);
        }
        
        string[] pointsTemp2 = pointsString.Split(new[] { "999" }, StringSplitOptions.RemoveEmptyEntries);
        int[] points = new int[pointsTemp2.Length];
        
        for (int i = 0; i < pointsTemp2.Length; i++)
        {
            points[i] = Convert.ToInt32(pointsTemp2[i]);
        }
        int temp;
        for (int i = 0; i < points.Length; i++)
        {
            for (int j = i + 1; j < points.Length; j++)
            {
                if (points[i] < points[j])
                {
                    //if(points[i] == points[j])
                    //{
                    //    int kek = 0;
                    //}
                    temp = points[i];
                    string stemp = name[i];
                    points[i] = points[j];
                    name[i]= name[j];
                    points[j] = temp;
                    name[j] = stemp;

                }
            }
        }
        string[] res = new string[20];
        for(int i = 0; i < points.Length; i++)
        {
            res[i] = string.Concat(name[i], points[i]);
        }
        string result = "";
        for (int i = 0; i < points.Length; i++) {
            result += res[i]+"\n";
        }
     
        scoreboard.text = result;
    }
    void OnGUI()
    {
        GUI.Label(new Rect(430, 450, 90, 100), "Your name:");
        playerName = GUI.TextField(new Rect(500, 450, 100, 20), playerName);
        if (GUI.Button(new Rect(500, 480, 50, 20), "Save"))
        {
            StreamWriter sw; //= new StreamWriter("PlayerName.txt");
            FileInfo fi = new FileInfo("PlayerName.txt");
            sw = fi.AppendText();
            sw.WriteLine(playerName + "\n\t\t\t\t Score" + Global.pts + "Score");

            sw.Close();
        }
        
    }
}
