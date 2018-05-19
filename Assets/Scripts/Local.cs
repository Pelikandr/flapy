using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Local : MonoBehaviour {

    public Text Text;
    public string EnglishValue;
    public string RussianValue;

	void Start () {
        LocalThisText();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LocalThisText()
    {
        if(Application.systemLanguage == SystemLanguage.Japanese)
        {
            Text.text = EnglishValue;
        }
        else
        {
            Text.text = RussianValue;
        }
    }
}
