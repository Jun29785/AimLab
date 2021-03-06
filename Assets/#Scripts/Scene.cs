using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene : Singleton<Scene>
{
    IEnumerator seconds()
    {
        yield return new WaitForSeconds(4);
    }
    
    public void LobbyScene()
    {
        GameManager.Instance.LoadScene("Lobby");
    }
    public void SettingsScene()
    {
        GameManager.Instance.LoadScene("Settings");
    }
    public void GameScene()
    {
        GameManager.Instance.GameInit();
        GameManager.Instance.LoadScene("Game");
        StartCoroutine(seconds());
        GameManager.Instance.IsStarted = true;
    }
}
