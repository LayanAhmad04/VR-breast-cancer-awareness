using UnityEngine;

public class ActivateObject : MonoBehaviour
{
    public GameObject objectToActivate;

    public void ActivateTarget()
    {
        objectToActivate.SetActive(true);
    }
}
