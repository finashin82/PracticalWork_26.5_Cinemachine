using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{
    [SerializeField] private PlayableDirector virtCamTimeline;

    private void OnTriggerEnter(Collider other)
    {
        virtCamTimeline.Play();   
    }

    private void OnTriggerExit(Collider other)
    {
        virtCamTimeline.Stop();
    }
}
