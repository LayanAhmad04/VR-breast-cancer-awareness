using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deactivate : MonoBehaviour
{
    public GameObject canvasToDisable;

    public void DisableCanvas()
    {
        canvasToDisable.SetActive(false);
    }
}
