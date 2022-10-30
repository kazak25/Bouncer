using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CylinderBehavior : MonoBehaviour
{
    [SerializeField] private GameObject _cylinders;
    private Painter _painter;
    [SerializeField] private CylinderIndicator _determineTheColor;
    private int indexColor;

    // Start is called before the first frame update


    void Start()
    {
        //_determineTheColor = FindObjectOfType<CylinderIndicator>();
        _painter = FindObjectOfType<Painter>();
        for (int i = 0; i < 5; i++)
        {
            var newCylinder = Instantiate(_cylinders);
            var changeColor = newCylinder.GetComponent<Renderer>();
            indexColor = _painter.SetRandomColor(changeColor.gameObject);
            _determineTheColor.whichColorCylinder(indexColor);


            newCylinder.transform.position = new Vector3(Random.Range(-52, 62), 3.1f, Random.Range(-52, 62));
        }
    }

    // Update is called once per frame
}