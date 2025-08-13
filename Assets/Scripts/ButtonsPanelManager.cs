using System.Collections;
using UnityEngine;

public class ButtonsPanelManager : MonoBehaviour
{
    public GameObject buttonsPanel;

    public void ShowButtonsForSeconds(float seconds)
    {
        StartCoroutine(ShowButtonsCoroutine(seconds));
    }

    private IEnumerator ShowButtonsCoroutine(float seconds)
    {
        if (buttonsPanel != null)
        {
            buttonsPanel.SetActive(true);
            yield return new WaitForSeconds(seconds);
            buttonsPanel.SetActive(false);
        }
    }
}
