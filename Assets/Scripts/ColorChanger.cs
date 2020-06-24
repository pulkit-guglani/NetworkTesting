using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    private Color[] _colors;

    [SerializeField]
    private TurnManager _turnManager;
    public Dropdown Color;
    void Start()
    {
        _colors = new[] {UnityEngine.Color.red,UnityEngine.Color.green, UnityEngine.Color.blue, UnityEngine.Color.yellow};
    }

    void Update()
    {
        
    }

    public void SetColor()
    {
        
        Camera.main.backgroundColor = _colors[Color.value];
        _turnManager.ChangeTurn();
        
    }
    
}
