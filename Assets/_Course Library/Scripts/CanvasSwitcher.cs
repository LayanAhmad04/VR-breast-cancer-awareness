using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSwitcher : MonoBehaviour
{

    public GameObject mainCanvas;
    public GameObject[] smallCanvases;

    public void SwitchCanvases()
    {
        // Hide the main canvas
        mainCanvas.SetActive(false);

        // Show the small canvases
        foreach (GameObject canvas in smallCanvases)
        {
            canvas.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
