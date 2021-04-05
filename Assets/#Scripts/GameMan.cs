using System;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMan : Singleton<GameMan>
{
    // 게임의 시작 상태
    public bool IsStarted;

    [SerializeField]
    public float MouseSens = 1f;
    
    public double CurrentScore;

    public double BestScore=0;

    public int bullet_cnt;
    private void Update()
    {
        ScoreUpdate();

        if (!IsStarted) 
        {
            Destroy(gameObject);
        }
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
            CurrentScore = BallMan.Instance.score;
        }
        if (CurrentScore > BestScore)
        {
            BestScore = CurrentScore;
        }
    }
}
