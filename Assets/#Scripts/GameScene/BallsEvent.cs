using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsEvent : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            DestroyObject(gameObject);
            BallMan.Instance.obj_cnt -= 1;
            BallMan.Instance.per_scr += 1;
            BallMan.Instance.score += 100 / BallMan.Instance.try_cnt;
            BallMan.Instance.try_cnt = 0;
        }
    }
}
