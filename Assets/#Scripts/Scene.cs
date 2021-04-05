using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene : MonoBehaviour
{
    public GameObject gamemanager;
    IEnumerator seconds()
    {
        yield return new WaitForSeconds(4);
    }

    public void LobbyScene()
    {
        GameMan.Instance.LoadScene("Lobby");
        Destroy(gamemanager);
    }
    public void SettingsScene()
    {
        GameMan.Instance.LoadScene("Settings");
    }
    public void GameScene()
    {
        GameMan.Instance.LoadScene("Game");
        StartCoroutine(seconds());
        GameMan.Instance.IsStarted = true;
    }
}
