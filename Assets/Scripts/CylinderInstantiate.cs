using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CylinderInstantiate : MonoBehaviour
{
    [SerializeField] private GameObject _cylinders;
    
    private Color _yellow;
    private Color _red;
    private Color _green;
    private Color _startColor;
    
    // Start is called before the first frame update
    
    private Color ChangeColor()
    {
        var color = Random.Range(1, 4);
        if (color == 1)
        {
            _startColor= _yellow;
        }
        if (color == 2)
        {
            _startColor= _green;
        }
        if (color == 3)
        {
            _startColor= _red;
        }

        return Color.red;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.GetComponent<CubeController>())
        {
            var color = collision.collider.gameObject.GetComponent<CubeController>();
            if (gameObject.GetComponent<Renderer>().material == color.GetComponent<Renderer>().material)
            {
                Destroy(_cylinders);
            }
        }
    }


    void Start()
    {
        
        _yellow = Color.yellow;
        _red=Color.red;
        _green=Color.green;
        for (int i = 0; i < 5; i++)
        {
             ChangeColor();
           var newCylinder= Instantiate(_cylinders);
           var changeColor = newCylinder.GetComponent<Renderer>();
           changeColor.material.color = _startColor;
            newCylinder.transform.position = new Vector3(Random.Range(-52, 62), 3.1f, Random.Range(-52, 62));
        }
        
    }

    // Update is called once per frame
    
}
