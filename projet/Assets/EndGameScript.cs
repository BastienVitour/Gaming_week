using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class EndGameScript : MonoBehaviour
{

    [SerializeField]
    private UnityEvent m_OnInteract;

    [SerializeField]
    Transform destination;

    void OnTriggerEnter(Collider col){

        Debug.Log("finish line");
        m_OnInteract.Invoke();
        //SceneManager.LoadScene(0);
        //col.transform.position = new Vector3(0,0,0);
        //col.transform.position = destination.position;
        //col.transform.Rotate(Vector3.up * 180);
        //Debug.Log(gameObject.name);
    }
}
