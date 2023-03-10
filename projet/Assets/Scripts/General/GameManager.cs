using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject m_HUD;

    [SerializeField]
    private GameObject m_FinishUI;

    [SerializeField]
    private GameObject m_FinalCamera;

    [SerializeField]
    private GameObject m_PlayerCamera;
    [SerializeField]
    private GameObject m_Player;

    public void FinishGame()
    {
        m_FinishUI.SetActive(true);
        m_FinalCamera.SetActive(true);
        m_HUD.SetActive(false);
        m_Player.SetActive(false);
        m_PlayerCamera.SetActive(false);

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            m_Player.SetActive(false);
            m_PlayerCamera.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            BackToMenu();
        }
    }

    public void Replay()
    {
        //Debug.Log("sqdfsgdhkugfdsghdtjfyku");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Next()
    {
        //Debug.Log("sqdfsgdhkugfdsghdtjfyku");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
