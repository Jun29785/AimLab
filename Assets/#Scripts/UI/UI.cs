using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public float LimitTime;
    public Text score;
    public Text timer;
    public Text Percen;
    public Text bestscore;
    public Text currentscore;
    public Text percentage;
    public GameObject gameoverpanel;

    private void Update()
    {
        if (GameManager.Instance.IsStarted && !GameManager.Instance.IsSetting)
        {
            UpdateText();
            TimerText();
        }

        if (!GameManager.Instance.IsStarted && gameoverpanel.activeSelf == false && !GameManager.Instance.IsSetting)
        {
            gameoverpanel.SetActive(true);
            GameManager.Instance.CheckBestScore();
            GameOverText();
        }
    }
    private void GameOverText()
    {
        bestscore.text = GameManager.Instance.BestScore.ToString("최고점수 : 00000점");
        currentscore.text = GameManager.Instance.CurrentScore.ToString("점수 : 00000점");
        percentage.text = BallMan.Instance.percent.ToString("정확도 : 00.00%");
    }
    private void UpdateText()
    {
        score.text = GameManager.Instance.CurrentScore.ToString();
        Percen.text = BallMan.Instance.percent.ToString("00.00%");
    }
    private void TimerText()
    {
        LimitTime -= Time.deltaTime;
        timer.text = Mathf.Round(LimitTime).ToString("00");

        if (LimitTime <= 0)
        {
            GameManager.Instance.IsStarted = false;
        }
    }
}
