using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenFar : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, gameObject.transform.position) > 50 && (player.transform.position.x - gameObject.transform.position.x) > 0) {
            Destroy(gameObject);
        }
    }
}
