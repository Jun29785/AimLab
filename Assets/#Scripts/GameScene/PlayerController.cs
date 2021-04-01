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
        if (GameManager.Instance.IsStarted)
        {
            CameraRotation();       // 마우스를 위아래(Y) 움직임에 따라 카메라 X 축 회전 
                                    //CharacterRotation();    // 마우스 좌우(X) 움직임에 따라 캐릭터 Y 축 회전 
        }
        if (!GameManager.Instance.IsStarted)
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
    }

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

    private void Zvalue(float value)
    {
        Vector3 ZeulerRot = transform.eulerAngles;
        ZeulerRot.z = value;
        transform.eulerAngles = ZeulerRot;
    }
    //private void CharacterRotation()  // 좌우 캐릭터 회전
    //{
    //    float _yRotation = Input.GetAxisRaw("Mouse X");
    //    Vector3 _characterRotationY = new Vector3(0f, _yRotation, 0f) * lookSensitivity;
    //    myRigid.MoveRotation(myRigid.rotation * Quaternion.Euler(_characterRotationY)); // 쿼터니언 * 쿼터니언
    //    // Debug.Log(myRigid.rotation);  // 쿼터니언
    //    // Debug.Log(myRigid.rotation.eulerAngles); // 벡터
    //}

}