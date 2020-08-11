using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Sample : MonoBehaviour
{
    string s;
    // Start is called before the first frame update
    void Start()
    {
        s = "ya";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        if (GUILayout.Button("button"))
        {
            s = DateTime.Now.ToString();
        }
        GUILayout.Label(s);
    }
}
