using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public GameObject Setting;

    private void Update()
    {
        OnOffSetting();
    }

    private void OnOffSetting()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Setting.activeSelf == false)
            {
                Setting.SetActive(true);
                GameManager.Instance.IsSetting = true;
            }
            else
            {
                Setting.SetActive(false);
                GameManager.Instance.IsSetting = false;
            }
        }
    }
}
