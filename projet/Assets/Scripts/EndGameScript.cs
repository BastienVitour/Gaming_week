using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class EndGameScript : MonoBehaviour
{

    [SerializeField]
    private UnityEvent m_OnInteract;

    void OnTriggerEnter(Collider col){

        Debug.Log("finish line");
        //PlayerPrefs.SetInt("level", SceneManager.GetActiveScene().buildIndex);
        m_OnInteract.Invoke();
        
    }
}
