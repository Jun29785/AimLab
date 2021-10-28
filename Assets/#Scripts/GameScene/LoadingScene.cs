using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingScene : MonoBehaviour
{
    public float starttime;
    public float currenttime;
    public float time;

    private void Awake()
    {
        starttime = Time.deltaTime;
    }
    void Update()
    {
        currenttime += Time.deltaTime;
        time = currenttime - starttime;
        if (time >= 3)
        {
            Scene.Instance.LobbyScene();
        }
    }

    public void ToLobby()
    {
        Scene.Instance.LobbyScene();
    }
}
