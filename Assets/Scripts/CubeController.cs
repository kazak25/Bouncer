using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private float _force = 20f;
    [SerializeField] private Rigidbody _rigidbody;


    private Color _sphereColor;
    private Vector3 _result;
    private Vector3 _target;
    private Painter _painter;


    // Start is called before the first frame update


    private void Start()
    {
        _painter = FindObjectOfType<Painter>();
    }


    public void StartMove(Vector3 target)
    {
        _target = target;
        _result = (_target - transform.position).normalized;
        _rigidbody.AddForce(new Vector3(_result.x, 0, _result.z) * _force);
    }
}