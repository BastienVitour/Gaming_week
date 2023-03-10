using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject platform;
    public float spawnRate = 0.25f;

    private float timer = 0;

    private float xPos = 7f;

    public GameObject player;

    public GameObject[] allPlatforms;

    // Start is called before the first frame update
    void Start()
    {
        spawnPlatform(7f, allPlatforms[0]);
        //InvokeRepeating ("jspq", 0, 2f); 
    }

    // Update is called once per frame
    void Update()
    {

        if ((xPos - player.transform.position.x) < 50) {
            int which = Random.Range(0, allPlatforms.Length);
            
            xPos += 8f;
            spawnPlatform(xPos, allPlatforms[which]);
        }

        /*if (timer < spawnRate) {
            timer = timer + Time.deltaTime;
        }
        else {
            
            int which = Random.Range(0, allPlatforms.Length);
            
            xPos += 8f;
            spawnPlatform(xPos, allPlatforms[which]);
            
            timer = 0;
        }*/
        
    }

    void jspq() {
        int which = Random.Range(0, allPlatforms.Length);
            
            xPos += 8f;
            spawnPlatform(xPos, allPlatforms[which]);
    }

    void spawnPlatform(float xPos, GameObject platform) 
    {
        Instantiate(platform, new Vector3(xPos, 0, 0), Quaternion.Euler(0, 0, 0));
    }
}
