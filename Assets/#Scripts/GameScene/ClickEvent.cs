using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : MonoBehaviour
{
    public GameObject Bullet;
    public Transform FirePos;
    

    private void Update()
    {
        if (GameManager1.Instance.IsStarted)
        {
            if (Input.GetMouseButtonDown(0) && GameManager1.Instance.bullet_cnt < 5)
            {
                Instantiate(Bullet, FirePos.transform.position, FirePos.transform.rotation);
                BAllMan.Instance.click_cnt += 1;
                GameManager1.Instance.bullet_cnt += 1;
                BAllMan.Instance.try_cnt += 1;
            }
        }
    }
}
