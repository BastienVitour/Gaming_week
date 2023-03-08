using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DashIconScript : MonoBehaviour
{

    public GameObject player;

    public bool dash;

    public Image image;

    public Sprite on;

    public Sprite off;

    public float timer;

    public float countdown = 0;

    public GameObject timerDisplay;

    private float roundedUp;
    
    // Start is called before the first frame update
    void Start()
    {
        Component[] components = timerDisplay.GetComponents(typeof(Component));
        foreach(Component component in components) {
            Debug.Log(component.ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {

        StarterAssets.FirstPersonController component = player.GetComponent<StarterAssets.FirstPersonController>();
        dash = component.dashed;

        TMPro.TextMeshProUGUI textOutput = timerDisplay.GetComponent<TMPro.TextMeshProUGUI>();

        roundedUp = Mathf.Ceil(timer);
               
        if (dash) {
            image.sprite = off;
            timerDisplay.SetActive(true);
            timer = timer - Time.deltaTime;
            textOutput.text = roundedUp.ToString();

        }
        else {
            image.sprite = on;
            timerDisplay.SetActive(false);
            timer = 3;
        }
    }
}
