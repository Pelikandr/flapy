using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text scr;
    public int points = 0;
    private int p = 0;
    Rigidbody2D pipe;

    // Use this for initialization
    void Start()
    {
        scr = gameObject.GetComponent(typeof(Text)) as Text;
        pipe = gameObject.GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
    }

    // Update is called once per frame
    void Update()
    {
        scr.text = " " + p;

        if (transform.position.x < 6)
        {
            points++;
        }

        if ((points % 170 == 0) && (points < 171))
        {
            p++;
        }
        if ((points > 340) && (points % 180 == 0))
        {
            p++;
        }

        Global.pts = p;   
    }
}
