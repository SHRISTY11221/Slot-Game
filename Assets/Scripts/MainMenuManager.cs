using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject gamePanel;
    public GameObject exitPopup;

    private void Start()
    {
        mainMenuPanel.SetActive(true);
        gamePanel.SetActive(false);
        exitPopup.SetActive(false);
    }

    public void PlayGame()
    {
        mainMenuPanel.SetActive(false);
        gamePanel.SetActive(true);
        exitPopup.SetActive(false);
    }

    public void BackToMenu()
    {
        gamePanel.SetActive(false);
        exitPopup.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    public void ExitGame()
    {
        exitPopup.SetActive(true);
    }

    public void YesExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void NoExit()
    {
        exitPopup.SetActive(false);
    }

   
}