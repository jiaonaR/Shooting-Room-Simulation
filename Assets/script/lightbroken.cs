using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightbroken : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject particle;
    private bool broken;
    public float fireRate = 2f;
    private float nextfire;
    void Start()
    {
        broken = false;
        nextfire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (broken)
        {

            if (Time.time > nextfire)
            {
                nextfire = Time.time + fireRate;
                Instantiate(particle, this.transform.position, this.transform.rotation);
            }


        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            foreach (Transform child in transform)
            {
                Destroy(child.gameObject,0f);//.SetActive(false);

            }
            broken = true;
        }
        
    }
}
