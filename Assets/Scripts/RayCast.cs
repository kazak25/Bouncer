using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private CubeController _cube;

    // Update is called once per frame
    void Update()
    {
        
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out var hitInfo, 1000f,_layerMask))
        {
            if (Input.GetMouseButtonDown(0))
            {
                var point = hitInfo.point;
                _cube.StartMove(point);
            }
        }
    }
}