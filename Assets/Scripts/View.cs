using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject youWonPanel;
    public GameObject bluePanel;
    public GameObject yellowPanel;
    public GameObject purplePanel;
    public Text hits;
    // Start is called before the first frame update
    public void LoadScene(string s)
    {
        SceneManager.LoadScene(s);
        
    }
    public void ShowGameOverPanel(bool show)
    {
        gameOverPanel.SetActive(show);
    }

    public void ShowYouWonPanel(bool show)
    {
        youWonPanel.SetActive(show);
    }
    public void ShowBluePanel()
    {
        bluePanel.SetActive(true);
        yellowPanel.SetActive(false);
        purplePanel.SetActive(false);
    }

    public void ShowYellowPanel()
    {
        yellowPanel.SetActive(true);
        purplePanel.SetActive(false);
        bluePanel.SetActive(false);
    }

    public void ShowPurplePanel()
    {
        bluePanel.SetActive(false);
        purplePanel.SetActive(true);
        yellowPanel.SetActive(false);
    }
    public void UpdateHits(int n)
    {
       hits.text = n.ToString();
    }
    public void LoadCurrentSceneAgain()
    {

    }

    public void LoadMainMenu()
    {

    }

    public void PlaySound(AudioSource audio)
    {
        audio.Play();
    }
}
