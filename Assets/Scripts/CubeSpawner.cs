using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _cube;


    // Start is called before the first frame update
    private void Start()
    {
        var control = _cube.GetComponent<CubeController>();
        _cube = control.gameObject;
    }

    private void Update()
    {
        if (_cube.transform.position.y < -1)
        {
            _cube.transform.position = new Vector3(0, 2, 0);
        }
    }
}