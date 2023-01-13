  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour, IPointerDownHandler
{
    static int sceneIdx = -1;

    public GameObject welcomePanel;
    public GameObject helpPanel;
    public GameObject exitChoicePanel;
    public GameObject exitPanel;
    // Start is called before the first frame update
    void Start()
    {
        if (sceneIdx == -1) 
        {
            welcomePanel.SetActive(true);
            helpPanel.SetActive(false);
        }
        else
        {
            welcomePanel.SetActive(false);
            helpPanel.SetActive(true);
        }
        exitChoicePanel.SetActive(false);
        exitPanel.SetActive(false);
    }

    private void OnDestroy()
    {
        Debug.Log(sceneIdx);
        sceneIdx = gameObject.scene.buildIndex;
    }

    public void Exit()
    {
        welcomePanel.SetActive(false);
        helpPanel.SetActive(false);
        exitChoicePanel.SetActive(true);
    }

    public void ConfirmExit()
    {
        exitChoicePanel.SetActive(false);
        exitPanel.SetActive(true);
    }

    public void CancelExit()
    {
        exitChoicePanel.SetActive(false);
        helpPanel.SetActive(true);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (welcomePanel.activeInHierarchy)
        {
            welcomePanel.SetActive(false);
            helpPanel.SetActive(true);
        }
        else if (exitPanel.activeInHierarchy)
        {
            Application.Quit();
        }
    }
}
