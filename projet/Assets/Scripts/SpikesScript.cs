using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpikesScript : MonoBehaviour
{

    [SerializeField]
    private UnityEvent m_OnInteract;

    void OnTriggerEnter(Collider col){

        Debug.Log("get spiked");
        m_OnInteract.Invoke();
        
    }

}
