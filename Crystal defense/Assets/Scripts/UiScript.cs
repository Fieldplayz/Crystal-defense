using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiScript : MonoBehaviour
{
    public GameObject[] UIpanels;
    public Button activeButton;

    private void Start()
    {
        
        foreach (var item in UIpanels)
        {
            //item.SetActive(false);
        }
    }

    public void OnEnable()
    {
        SetActiveButton();
    }

    public void OpenPanel(int PanelNumber)
    {
        UIpanels[PanelNumber].SetActive(true);
    }
    public void ClosePanel(int PanelNumber)
    {
        UIpanels[PanelNumber].SetActive(false);
    }

    public void CloseAllPanels()
    {
        foreach (var item in UIpanels)
        {
            item.SetActive(false);
        }
    }
    public void OpenAllPanels()
    {
        foreach (var item in UIpanels)
        {
            item.SetActive(true);
        }
    }
    public void SetActiveButton()
    {
        activeButton.Select();
    }

    public void LoadScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
