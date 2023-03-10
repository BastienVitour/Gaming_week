using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour{

    [SerializeField]
    Transform destination;

    void OnTriggerEnter(Collider col){

        col.transform.position = destination.position;
        col.transform.Rotate(Vector3.up * 180);
    }
}
