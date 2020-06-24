using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    private Color[] _colors;
    
    public Dropdown Color;
    // Start is called before the first frame update
    void Start()
    {
        _colors = new[] {UnityEngine.Color.red,UnityEngine.Color.green, UnityEngine.Color.blue, UnityEngine.Color.yellow};
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetColor()
    {
        Camera.main.backgroundColor = _colors[Color.value];
    }
    
}
