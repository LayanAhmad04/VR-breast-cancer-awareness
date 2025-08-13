using UnityEngine;

public class FollowCameraFoot : MonoBehaviour
{
    public Transform cameraTransform;
    public Vector3 offset = new Vector3(0, -1.5f, 0); // offset to simulate foot

    void LateUpdate()
    {
        transform.position = cameraTransform.position + offset;
    }
}
