using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensitivityText : MonoBehaviour
{
    public Text Sens;
    
    void Update()
    {
        Sens.text = GameManager.Instance.MouseSens.ToString("0.000");
    }
}
