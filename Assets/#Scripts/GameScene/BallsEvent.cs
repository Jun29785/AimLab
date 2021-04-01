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
            BallManager.Instance.obj_cnt -= 1;
            BallManager.Instance.per_scr += 1;
            BallManager.Instance.score += 100 / BallManager.Instance.try_cnt;
            BallManager.Instance.try_cnt = 0;
        }
    }
}
