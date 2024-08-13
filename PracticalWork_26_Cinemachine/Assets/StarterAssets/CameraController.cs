using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject trackCamera;
    
    public void TrackCameraOff()
    {
        trackCamera.SetActive(false);
    }
}
