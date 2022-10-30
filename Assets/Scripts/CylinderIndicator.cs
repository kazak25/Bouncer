using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CylinderIndicator : MonoBehaviour
{
    [SerializeField]  private TextMeshProUGUI _yellow;
    [SerializeField]  private TextMeshProUGUI _red;
    [SerializeField]  private TextMeshProUGUI _green;


    private Painter _painter;
    public int _yellowCylinder;
    public int _redCylinder;
    public int _greenCylinder;
    
    // Start is called before the first frame update
    private void Start()
    {
        _painter = FindObjectOfType<Painter>();
    }

    public void whichColorCylinder(int num)
    {
        if (num == 0)
        {
            _yellowCylinder++;
        }
        if(num==1)
        {
            _redCylinder++;
        }
        if(num==2)
        {
            _greenCylinder++;
        }
    }
    
    public void WhatColorIsTaken(Color gameObject)
    {
     
     if (gameObject == _painter._colors[0])
     {
         _yellowCylinder--;
     }
     if (gameObject == _painter._colors[1])
     {
         _redCylinder--;
     }
     if (gameObject == _painter._colors[2])
     {
         _greenCylinder--;
     }
     
    }

    private void Update()
    {
        _yellow.text = _yellowCylinder.ToString();
        _red.text = _redCylinder.ToString();
        _green.text = _greenCylinder.ToString();
    }
}

    // Update is called once per frame

