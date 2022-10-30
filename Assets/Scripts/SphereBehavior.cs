using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SphereBehavior : MonoBehaviour
{
    [SerializeField] private GameObject _spheres;
    
    private Painter _painter;
        
        // Start is called before the first frame update
        

        public GameObject StartInstantiate()
        {
            
            var newCylinder= Instantiate(_spheres);
            var changeColor = newCylinder.GetComponent<Renderer>();
            _painter.SetRandomColor(changeColor.gameObject);
            newCylinder.transform.position = new Vector3(Random.Range(-52, 62), 3.1f, Random.Range(-52, 62));
            return newCylinder;

        }
    
    
        void Start()
        {
            _painter = FindObjectOfType<Painter>();
            
            for (int i = 0; i < 3; i++)
            {
                StartInstantiate();
            }
            
        }
}
