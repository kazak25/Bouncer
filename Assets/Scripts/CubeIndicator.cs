using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CubeIndicator : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _ourClicks;
    
    private int _numberOfClicks;
    // Start is called before the first frame update
    public void HowManyClicks(int num)
    {
        _numberOfClicks = num;
    }

    // Update is called once per frame
    void Update()
    {
        _ourClicks.text = _numberOfClicks.ToString();
    }
}
