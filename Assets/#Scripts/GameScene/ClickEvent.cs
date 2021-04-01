using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : MonoBehaviour
{
    public GameObject Bullet;
    public Transform FirePos;
    

    private void Update()
    {
        if (GameManager.Instance.IsStarted)
        {
            if (Input.GetMouseButtonDown(0) && GameManager.Instance.bullet_cnt < 5)
            {
                Instantiate(Bullet, FirePos.transform.position, FirePos.transform.rotation);
                BallManager.Instance.click_cnt += 1;
                GameManager.Instance.bullet_cnt += 1;
                BallManager.Instance.try_cnt += 1;
            }
        }
    }
}
