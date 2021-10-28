using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class BallMan : Singleton<BallMan>
{
    #region 변수 선언
    public int obj_cnt;

    public float score = 0;
    public float percent = 0f;
    public float per_scr;

    public int click_cnt;
    public int try_cnt = 0;

    public GameObject balls;
    #endregion

    void Start()
    {
        GameManager.Instance.MouseSens = 1f;
    }

    void Update()
    {
        if (GameManager.Instance.IsStarted && !GameManager.Instance.IsSetting)
        {
            Spawn();
            UpdateText();
        }
    }

    private void Init()
    {
        GameManager.Instance.Bullet_Cnt = 5;
    }

    private void UpdateText()
    {
        percent = per_scr / click_cnt;
        if (percent > 1)
        {
            percent = 1;
        }
        //score *= percent * 100;
    }
    
    private void Spawn()
    {
        double randomY = Random.Range((float)1.5, (float)12.5);
        double randomX = Random.Range((float)-10.5, (float)9.5);
        double staticZ = 11.65;
        if (obj_cnt < 3)
        {
            GameObject ball = (GameObject)Instantiate(balls, new Vector3((float)randomX, (float)randomY, (float)staticZ), Quaternion.identity);
            obj_cnt += 1;
            Debug.Log("create balls");
        }
    }
}
