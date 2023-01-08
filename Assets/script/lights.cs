using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lights : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject respawnPrefab;
    public GameObject[] respawns;
    public bool lighton;
    private AudioSource sounds;
    public float fireRate = 2f;
    private float nextfire;
    void Start()
    {
        respawns = GameObject.FindGameObjectsWithTag("light");
        sounds = GetComponent<AudioSource>();

    }
    void OnTriggerEnter(Collider other)
    {
        if (Time.time > nextfire)
        {
            nextfire = Time.time + fireRate;


            lighton = !lighton;

            foreach (GameObject respawn in respawns)
            {
                respawn.SetActive(lighton);
            }

            if (!lighton)
            {

                transform.Rotate(60, 0, 0);
                sounds.Play();
            }
            else
            {
                transform.Rotate(-60, 0, 0);
                sounds.Play();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("asdasd");
    }
}
