using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class InfiniteLevelView : MonoBehaviour
{

    public Text score;
    public Text hits;
    public GameObject gameOverPanel;
    // Start is called before the first frame update
    public void UpdateScore(int n)
    {
        score.text = n.ToString();
    }

    public void UpdateHits(int n)
    {
        hits.text = n.ToString();
    }

    public void ShowGameOverPanel(bool show)
    {
        gameOverPanel.SetActive(show);
    }

    public void TryAgain()
    {
        gameOverPanel.SetActive(false);
        SceneManager.LoadScene("InfiniteLevel");
    }

    public void GoToMainMenu()
    {
        gameOverPanel.SetActive(false);
        SceneManager.LoadScene("Scenes/MainMenu");
    }

    public void LoadScene(string s)
    {
        SceneManager.LoadScene(s);
    }
}
