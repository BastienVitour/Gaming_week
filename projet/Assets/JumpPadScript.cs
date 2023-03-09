using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class JumpPadScript : MonoBehaviour
{

    [SerializeField]
    private UnityEvent m_OnInteract;

    void OnTriggerEnter(Collider col){

        Debug.Log("jump pad");
        m_OnInteract.Invoke();
        
    }
}
