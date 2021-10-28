using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : MonoBehaviour
{
    public GameObject pointer;

    IEnumerator Pointer()
    {
        yield return new WaitForSeconds(.01f);
        if (pointer.activeSelf)
        {
            pointer.SetActive(false);
        }
    }

    private void Update()
    {
        if (GameManager.Instance.IsStarted)
        {
            if (Input.GetMouseButtonDown(0) && !pointer.activeSelf)
            {
                pointer.SetActive(true);
                StartCoroutine(Pointer());
                BallMan.Instance.click_cnt += 1;
                BallMan.Instance.try_cnt += 1;
            }
        }
    }
}
