using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float HorizonsRot;
    private float VerticalRot;
    public float PlayerXRotValue;
    public float PlayerYRotValue;

    [SerializeField]
    //private Camera theCamera;
    //private Rigidbody myRigid;

    void Start()
    {
        transform.GetComponent<PlayerController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()  // 컴퓨터마다 다르지만 대략 1초에 60번 실행
    {
        if (GameManager.Instance.IsStarted && !GameManager.Instance.IsSetting)
        {
            CameraRotation();       // 마우스를 위아래(Y) 움직임에 따라 카메라 X 축 회전 
                                    //CharacterRotation();    // 마우스 좌우(X) 움직임에 따라 캐릭터 Y 축 회전 
        }
        if (!GameManager.Instance.IsStarted && !GameManager.Instance.IsSetting)
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
    #region 화면이 마우스를 따라가기
    private void CameraRotation()
    {
        HorizonsRot = Input.GetAxis("Mouse X") * 150f * GameManager.Instance.MouseSens * Time.deltaTime;
        VerticalRot = Input.GetAxis("Mouse Y") * 150f * GameManager.Instance.MouseSens * Time.deltaTime;

        PlayerXRotValue -= VerticalRot;
        PlayerYRotValue += HorizonsRot;

        PlayerXRotValue = Mathf.Clamp(PlayerXRotValue, -80, 80);
        PlayerYRotValue = Mathf.Clamp(PlayerYRotValue, -60, 60);

        Zvalue(0.0f);

        transform.rotation = Quaternion.Euler(PlayerXRotValue, PlayerYRotValue, 0);
    }
    #endregion


    private void Zvalue(float value)
    {
        Vector3 ZeulerRot = transform.eulerAngles;
        ZeulerRot.z = value;
        transform.eulerAngles = ZeulerRot;
    }
}