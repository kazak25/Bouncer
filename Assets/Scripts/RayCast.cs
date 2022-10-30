using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private CubeController _cube;

    private int _numberOfClicks;
    private CubeIndicator _cubeIndicator;

    // Update is called once per frame
    private void Start()
    {
        _cubeIndicator = FindObjectOfType<CubeIndicator>();
    }

    void Update()
    {
        
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out var hitInfo, 1000f,_layerMask))
        {
            if (Input.GetMouseButtonDown(0))
            {
                var point = hitInfo.point;
                _cube.StartMove(point);
                _numberOfClicks++;
                _cubeIndicator.HowManyClicks(_numberOfClicks);
            }
        }
    }
}