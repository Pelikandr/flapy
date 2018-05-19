using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {
    public InputField input;
    // Use this for initialization
    void Start () {
        Global.playerName = input.text;
        Debug.Log(Global.playerName);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
