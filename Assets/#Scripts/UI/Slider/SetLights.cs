using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLights : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
    }

    public void SetAlpha(float slidervalue)
    {
        BallMan.Instance.Alphaval = slidervalue;
    }
}
