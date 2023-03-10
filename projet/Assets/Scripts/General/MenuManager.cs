using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    //public GameObject[] objects;

    public Button[] buttons;

    public void Start() {
        /*for (int i = 0; i < 8; i++)
        {
            buttons[i].interactable = false;
        }*/
        //Debug.Log(PlayerPrefs.GetInt("level"));
        //makeGreen(PlayerPrefs.GetInt("level"));
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void LevelSelection(int level) {
        SceneManager.LoadScene(level);
    }

    /*public void makeGreen(int level) {
        //buttons[level].colors.normalColor = Color.green;
        //Debug.Log(level);
        //buttons[level-1].GetComponent<Image>().color = Color.green;
        buttons[level].interactable = true;
        for (int i = 0; i < level; i++)
        {
            buttons[i].GetComponent<Image>().color = Color.green;
            buttons[i].interactable = true;
            //Debug.Log(level-1);
        }
    }*/
}
