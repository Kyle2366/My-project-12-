using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private string newGameLevel1 = "Level1";
    [SerializeField] private string MainMenu = "Main Menu";
    private void Awake()
    {
        AutoSetDiff();
    }

    private void Update()
    {
        string diff = PlayerPrefs.GetString("difficulty");
        print("difficulty is " + diff);
    }

    public void LoadLevelOne()
    {
        SceneManager.LoadScene(newGameLevel1);
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(MainMenu);
    }

    public void AutoSetDiff()
    {
        PlayerPrefs.SetString("difficulty","easy");
    }

    public void Easy()
    {
        PlayerPrefs.SetString("difficulty", "easy");
    }
    public void Medium()
    {
        PlayerPrefs.SetString("difficulty", "medium");
    }
    public void Hard()
    {
        PlayerPrefs.SetString("difficulty", "hard");
    }
}
