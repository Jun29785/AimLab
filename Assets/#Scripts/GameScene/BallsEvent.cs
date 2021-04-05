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
            BAllMan.Instance.obj_cnt -= 1;
            BAllMan.Instance.per_scr += 1;
            BAllMan.Instance.score += 100 / BAllMan.Instance.try_cnt;
            BAllMan.Instance.try_cnt = 0;
        }
    }
}
