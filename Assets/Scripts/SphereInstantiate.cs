using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SphereInstantiate : MonoBehaviour
{
    [SerializeField] private GameObject _spheres;
    
        private Color _yellow;
        private Color _red;
        private Color _green;
        private Color _startColor;
        private Color _cubeColor;
        
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

        public GameObject StartInstantiate()
        {
            _yellow = Color.yellow;
            _red=Color.red;
            _green=Color.green;
            ChangeColor();
            var newCylinder= Instantiate(_spheres);
            var changeColor = newCylinder.GetComponent<Renderer>();
            changeColor.material.color = _startColor;
            newCylinder.transform.position = new Vector3(Random.Range(-52, 62), 3.1f, Random.Range(-52, 62));
            return newCylinder;

        }
    
    
        void Start()
        {
            
            for (int i = 0; i < 3; i++)
            {
                StartInstantiate();
            }
            
        }
}
