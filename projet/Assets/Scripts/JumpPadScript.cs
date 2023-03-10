using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class JumpPadScript : MonoBehaviour
{

    [SerializeField]
    private UnityEvent m_OnInteract;

    private StarterAssets.FirstPersonController function;

    void OnTriggerEnter(Collider col){

        Debug.Log("jump pad");
        m_OnInteract.Invoke();
        function = GameObject.FindGameObjectWithTag("Player").GetComponent<StarterAssets.FirstPersonController>();
        function.Bounce();
        
    }
}
