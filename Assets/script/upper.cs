using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upper : MonoBehaviour
{
    // Start is called before the first frame update
    private float roll;
    private bool rollingup = false;
    private AudioSource sounds;
    void Start()
    {
        roll = 0;
        sounds = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (this.transform.localRotation.eulerAngles.z < 360 && this.transform.localRotation.eulerAngles.z >= 270 && rollingup)
        {
            transform.Rotate(0, 0, roll);
            if (!sounds.isPlaying)
            {
                sounds.Play();
            }
        }
        
        else if (this.transform.localRotation.eulerAngles.z > 270 && !rollingup)
        {
            transform.Rotate(0, 0, roll);
            if (!sounds.isPlaying)
            {
                sounds.Play();
            }
    
        }
        else
        {
            sounds.Stop();

        }
    }
    void rollup()
    {
        rollingup = true;
        roll = 0.4f;
        transform.Rotate(0, 0, roll);
    }

    void rolldown()
    {
        rollingup = false;
        roll = -0.4f;
        transform.Rotate(0, 0, roll);
    }
}
