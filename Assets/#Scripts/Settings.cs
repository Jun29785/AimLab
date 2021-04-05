using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Slider Sensitivity;
    public Slider Sounds;
    public Slider Light;

    public void SetSensitivity(float value)
    {
        Sensitivity.value = value;
        GameMan.Instance.MouseSens = Sensitivity.value;
    }

    public void SetSounds(float value)
    {
        Sounds.value = value;
    } 

    public void SetLight(float value)
    {
        Light.value = value;
    }
}
