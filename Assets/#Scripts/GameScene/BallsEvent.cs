using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsEvent : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy();
        }
    }

    private void Destroy()
    {
        this.gameObject.SetActive(false);
        BallMan.Instance.obj_cnt -= 1;
        BallMan.Instance.per_scr += 1;
        GameManager.Instance.CurrentScore += 100 + (10 *  (5-BallMan.Instance.try_cnt));
        BallMan.Instance.try_cnt = 0;
        DestroyObject(this.gameObject);
    }
}
