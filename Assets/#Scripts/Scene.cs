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
        GameManager1.Instance.LoadScene("Lobby");
        Destroy(gamemanager);
    }
    public void SettingsScene()
    {
        GameManager1.Instance.LoadScene("Settings");
    }
    public void GameScene()
    {
        GameManager.Instance.LoadScene("Game");
        StartCoroutine(seconds());
        GameManager1.Instance.IsStarted = true;
    }
}
