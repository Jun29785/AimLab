using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallManager : Singleton<BallManager>
{
    public int obj_cnt;

    public float score = 0;
    public float percent = 0f;
    public float per_scr;

    public int click_cnt;
    public int try_cnt;

    public GameObject balls;
    public GameObject obj;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.IsStarted)
        {
            Spawn();
            UpdateText();
        }
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
        if (obj_cnt <4)
        {
            GameObject ball = (GameObject)Instantiate(balls, new Vector3((float)randomX, (float)randomY, (float)staticZ), Quaternion.identity);
            obj_cnt += 1;
        }
    }
}
