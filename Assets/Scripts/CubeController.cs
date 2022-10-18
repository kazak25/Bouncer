using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private float _force = 20f;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private GameObject _sphereSpawner;


    private SphereInstantiate _sphere;
    private Renderer _cubeColor;
    private Color _sphereColor;
    private Vector3 _result;
    private Vector3 _target;


    // Start is called before the first frame update


    private void Start()
    {
        _cubeColor = GetComponent<Renderer>();
        _sphere = _sphereSpawner.GetComponent<SphereInstantiate>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cylinder"))
        {
            
            var color = collision.gameObject.GetComponent<Renderer>();
            if (color.material.color == _cubeColor.material.color)
            {
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


    public void StartMove(Vector3 target)
    {
        _target = target;
        _result = (_target - transform.position).normalized;
        _rigidbody.AddForce(new Vector3(_result.x, 0, _result.z) * _force);
    }
    
}