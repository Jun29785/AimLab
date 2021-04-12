using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public GameObject Setting;
    public GameObject Lobby;
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
                BallMan.Instance.IsSetting = true;
            }
            else
            {
                Setting.SetActive(false);
                BallMan.Instance.IsSetting = false;
            }
        }
    }

    private void OnLobby()
    {
        if (BallMan.Instance.IsLobby && Lobby.activeSelf == false)
            Lobby.SetActive(true);
        else
            Lobby.SetActive(false);
    }
}
