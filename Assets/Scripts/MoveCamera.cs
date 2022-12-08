using System;
using Cinemachine;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera virtualCamera;
    [SerializeField] private Vector3 bodyOffset;
    [SerializeField] private Vector3 aimOffset;
    private bool _isPressing;

    private void OnMouseEnter()
    {
        if (_isPressing) return;
        _isPressing = true;
        var currentObject = transform;
        virtualCamera.Follow = currentObject;
        virtualCamera.LookAt = currentObject;
                    
                    
        if (bodyOffset != Vector3.zero)
        {
            virtualCamera.GetCinemachineComponent<CinemachineTransposer>().m_FollowOffset = bodyOffset;
        }
            
        if (aimOffset != Vector3.zero)
        {
            virtualCamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = aimOffset;
            
        }
    }

    private void OnMouseExit()
    {
        _isPressing = false;
    }
}
