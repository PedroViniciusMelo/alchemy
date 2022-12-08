using Cinemachine;
using UnityEngine;
using UnityEngine.UI;

public class ResetToPrevious : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera virtualCamera;
    [SerializeField] private Transform lookAtRigidbody;
    public Button button;
    [SerializeField] private Vector3 bodyOffset;
    [SerializeField] private Vector3 aimOffset;
    
    void Start()
    {
        var btn = button.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        virtualCamera.Follow = lookAtRigidbody;
        virtualCamera.LookAt = lookAtRigidbody;
        
        if (bodyOffset != Vector3.zero)
        {
            virtualCamera.GetCinemachineComponent<CinemachineTransposer>().m_FollowOffset = bodyOffset;
        }
            
        if (aimOffset != Vector3.zero)
        {
            virtualCamera.GetCinemachineComponent<CinemachineComposer>().m_TrackedObjectOffset = aimOffset;
            
        }
    }

}
