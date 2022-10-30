using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollison : MonoBehaviour
{
    [SerializeField] private GameObject _sphereSpawner;

    private CylinderIndicator _determineTheColor;
    private SphereBehavior _sphere;
    private Renderer _cubeColor;

    // Start is called before the first frame update

    private void Start()
    {
        _cubeColor = GetComponent<Renderer>();
        _sphere = _sphereSpawner.GetComponent<SphereBehavior>();
        _determineTheColor = FindObjectOfType<CylinderIndicator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cylinder"))
        {
            var color = collision.gameObject.GetComponent<Renderer>();
            if (color.material.color == _cubeColor.material.color)
            {
                _determineTheColor.WhatColorIsTaken(collision.gameObject.GetComponent<Renderer>().material.color);
                Destroy(collision.gameObject);
            }
        }


        if (collision.gameObject.CompareTag("Sphere"))
        {
            var color = collision.gameObject.GetComponent<Renderer>();

            _cubeColor.material.color = color.material.color;
            Destroy(collision.gameObject);
            _sphere.StartInstantiate();
        }
    }
}