using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameObject MainMenu, PlayMenu;

    // Start is called before the first frame update
    void Start()
    {
        MainMenu.SetActive(true);
        PlayMenu.SetActive(false);
    }

    public void PlayButton()
    {
        MainMenu.SetActive(false);
        PlayMenu.SetActive(true);
    }

    public void Level1Button()
    {
        SceneManager.LoadScene("p1");
    }
    public void Level2Button()
    {
        SceneManager.LoadScene("p2");
    }
    public void Level3Button()
    {
        SceneManager.LoadScene("p3");
    }
    public void Level4Button()
    {
        SceneManager.LoadScene("p4");
    }
    public void Level5Button()
    {
        SceneManager.LoadScene("p5");
    }
    public void Level6utton()
    {
        SceneManager.LoadScene("p6");
    }
    public void Level7Button()
    {
        SceneManager.LoadScene("p7");
    }
    public void Level8Button()
    {
        SceneManager.LoadScene("p8");
    }
    public void Level9Button()
    {
        SceneManager.LoadScene("p9");
    }

    public void BackButton()
    {
        MainMenu.SetActive(true);
        PlayMenu.SetActive(false);
    }

    public void ExitButton()
    {
        Debug.Log("Exit from Game");
        Application.Quit();
    }
}
