using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public bool IsStarted;
    public bool IsSetting;

    [SerializeField]
    public float MouseSens = 1f;

    public float CurrentScore;
    public float BestScore;

    public int Bullet_Cnt;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void CheckBestScore()
    {
        if (CurrentScore > BestScore)
        {
            BestScore = CurrentScore;
        }
    }

    public void GameInit()
    {
        GameManager.Instance.CurrentScore = 0;
    }
}
