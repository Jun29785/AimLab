using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : MonoBehaviour
{
    public GameObject Bullet;
    public Transform FirePos;
    

    private void Update()
    {
        if (GameMan.Instance.IsStarted)
        {
            if (Input.GetMouseButtonDown(0) && GameMan.Instance.bullet_cnt < 5)
            {
                Instantiate(Bullet, FirePos.transform.position, FirePos.transform.rotation);
                BallMan.Instance.click_cnt += 1;
                GameMan.Instance.bullet_cnt += 1;
                BallMan.Instance.try_cnt += 1;
            }
        }
    }
}
