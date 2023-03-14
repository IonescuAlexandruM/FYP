using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraScript : MonoBehaviour
{
    private CinemachineVirtualCamera cvCamera;
    private Cinemachine3rdPersonFollow c3dFollow;

    [SerializeField] private Button behind;
    [SerializeField] private Button above;
    [SerializeField] private Button topRight;
    [SerializeField] private Button botRight;

    // Start is called before the first frame update
    void Start()
    {
        cvCamera = GetComponent<CinemachineVirtualCamera>();
        c3dFollow = cvCamera.GetCinemachineComponent<Cinemachine3rdPersonFollow>();

        ReloadCameraAngle(PlayerPrefs.GetFloat("_upDown_"), PlayerPrefs.GetFloat("_leftRight_"), PlayerPrefs.GetFloat("_forwardBackward_"));
        

        Button behindButton= behind.GetComponent<Button>();
        behindButton.onClick.AddListener(()=>ChangeCameraPosition(0f, 0.5f, 0.5f)); 

        Button aboveButton = above.GetComponent<Button>();
        aboveButton.onClick.AddListener(() => ChangeCameraPosition(0.5f, 0.5f, 0.5f));

        Button topRightButton = topRight.GetComponent<Button>();
        topRightButton.onClick.AddListener(() => ChangeCameraPosition(0f, 0.8f, 1.5f));  
        
        Button botRightButton = botRight.GetComponent<Button>();
        botRightButton.onClick.AddListener(() => ChangeCameraPosition(0f, 0.8f, 0.5f));


    }

    void ReloadCameraAngle(float upDown, float leftRight, float forwardBackward)
    {
        c3dFollow.ShoulderOffset.y = upDown;
        c3dFollow.CameraSide = leftRight;
        c3dFollow.CameraDistance = forwardBackward;
    }


    void ChangeCameraPosition(float upDown,float leftRight,float forwardBackward)
    {
        c3dFollow.ShoulderOffset.y = upDown;
        PlayerPrefs.SetFloat("_upDown_", upDown);

        c3dFollow.CameraSide = leftRight;
        PlayerPrefs.SetFloat("_leftRight_", leftRight);

        c3dFollow.CameraDistance = forwardBackward;
        PlayerPrefs.SetFloat("_forwardBackward_", forwardBackward);
    }
}
