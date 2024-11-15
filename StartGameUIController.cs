using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGameUIController : MonoBehaviour
{
    public GameObject StartGamePanel;
    public Button playButton;

    void Start()
    {
        if (StartGamePanel != null)
        {
            StartGamePanel.SetActive(true);
        }

        if (playButton != null)
        {
            playButton.onClick.AddListener(StartGame);
        }

        Time.timeScale = 0;
    }

    void StartGame()
    {
        if (StartGamePanel != null)
        {
            StartGamePanel.SetActive(false);
        }

        if (playButton != null)
        {
            playButton.gameObject.SetActive(false);
        }

        Time.timeScale = 1;
    }
}
