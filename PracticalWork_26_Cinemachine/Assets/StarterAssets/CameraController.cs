using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject trackCamera;

    [SerializeField] private GameObject freelookCamera;
    
    public void TrackCameraOff()
    {
        trackCamera.SetActive(false);
    }

    public void FreeLookCameraOff()
    {
        freelookCamera.SetActive(false);
    }
}
