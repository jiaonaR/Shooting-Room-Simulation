using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emergency : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject redlight;
    public Light red;
    public GameObject respawnPrefab;
    public GameObject[] respawns;
    public bool alldisabled;
    private float to;
    void Start()
    {
        red = redlight.GetComponent<Light>();
        respawns = GameObject.FindGameObjectsWithTag("light");
        alldisabled = false;
        to = 5f;
    }
    void Update()
    {
        alldisabled = true;
        respawns = GameObject.FindGameObjectsWithTag("light");
        foreach (GameObject respawn in respawns)
        {
            if(respawn.activeSelf == true)
                {
                    alldisabled = false;
            
                }
        }
        respawns = GameObject.FindGameObjectsWithTag("frontlight");
        foreach (GameObject respawn in respawns)
        {
            if (respawn.activeSelf == true)
            {
                alldisabled = false;

            }
        }

        redlight.SetActive(alldisabled);
        red.intensity = Mathf.Lerp(red.intensity, to, 0.5f * Time.deltaTime);
        if (red.intensity > 3.5)
        {
            to = 1f;
        }
        if (red.intensity < 1.5)
        {
            to = 5f;
        }
    }

    
}
