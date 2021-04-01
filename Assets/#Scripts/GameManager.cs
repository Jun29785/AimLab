using System;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    // 게임의 시작 상태
    public bool IsStarted;

    [SerializeField]
    public float MouseSens = 1f;
    
    public double CurrentScore;

    public double BestScore=0;

    public int bullet_cnt;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    private void Update()
    {
        ScoreUpdate();
    }
    // 씬 전환 기능 메서드
    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
   
    private void ScoreUpdate()
    {
        if (IsStarted)
        {
            CurrentScore = BallManager.Instance.score;
        }
        if (CurrentScore > BestScore)
        {
            BestScore = CurrentScore;
        }
    }
}
