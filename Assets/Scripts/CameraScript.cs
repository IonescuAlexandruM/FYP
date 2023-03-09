using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraScript : MonoBehaviour
{
    private CinemachineVirtualCamera cvCamera;
    private Cinemachine3rdPersonFollow c3dFollow;

    [SerializeField] private Slider upDown;
    [SerializeField] private Slider leftRight;
    [SerializeField] private Slider forwardBackward;

    // Start is called before the first frame update
    void Start()
    {
        cvCamera = GetComponent<CinemachineVirtualCamera>();
        c3dFollow = cvCamera.GetCinemachineComponent<Cinemachine3rdPersonFollow>();

        UpDownValueChanged(PlayerPrefs.GetFloat("_upDown_"));
        LeftRightValueChanged(PlayerPrefs.GetFloat("_leftRight_"));
        ForwardBackwardValueChanged(PlayerPrefs.GetFloat("_forwardBackward_"));

        upDown.onValueChanged.AddListener(delegate { UpDownValueChanged(); });
        leftRight.onValueChanged.AddListener(delegate { LeftRightValueChanged(); });
        forwardBackward.onValueChanged.AddListener(delegate { ForwardBackwardValueChanged(); });

    }

    void UpDownValueChanged()
    {
        c3dFollow.ShoulderOffset.y = upDown.value;
        PlayerPrefs.SetFloat("_upDown_", upDown.value);
    } 
    
    void UpDownValueChanged(float value)
    {
        c3dFollow.ShoulderOffset.y = value;
        upDown.value = value;
    }

    void LeftRightValueChanged()
    {
        c3dFollow.CameraSide = leftRight.value;
        PlayerPrefs.SetFloat("_leftRight_", leftRight.value);
    }
    
    void LeftRightValueChanged(float value)
    {
        c3dFollow.CameraSide = value;
        leftRight.value = value;
    }

    void ForwardBackwardValueChanged()
    {
        c3dFollow.CameraDistance = forwardBackward.value;
        PlayerPrefs.SetFloat("_forwardBackward_", forwardBackward.value);
    }
    
    void ForwardBackwardValueChanged(float value)
    {
        c3dFollow.CameraDistance = value;
        forwardBackward.value = value;
    }
}
