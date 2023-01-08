using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetarget : MonoBehaviour
{
    private bool movingup;
    private bool movingback;
    private Vector3 originalposition;
    private Vector3 currentposition;
    private Vector3 frontposition;
    private AudioSource sounds;
    private Vector3 result;
    void Start()
    {
        movingup = false;
        movingback = false;
        originalposition = this.transform.position;
        frontposition = new Vector3(-7.29f,originalposition.y,originalposition.z);
        sounds = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        currentposition = this.transform.position;
        if (movingup)
        {
            result = Vector3.Lerp(currentposition, frontposition, 0.4f * Time.deltaTime);
            this.transform.position = result;
            if (!sounds.isPlaying )
            {
                sounds.Play();
            }
            
        }
        else if (movingback)
        {
            result = Vector3.Lerp(currentposition, originalposition, 0.4f * Time.deltaTime);
            this.transform.position = result;
            if (!sounds.isPlaying)
            {
                sounds.Play();
            }
           
        }
       


        if (result.x <= -7.2)
        {
            goback();
            sounds.Stop();
        }
        if (result.x >= originalposition.x-0.1)
        {

            sounds.Stop();

        }
       
    }
    void gofront()
    {
        movingup = true;
        movingback = false;
        

    }


    void goback()
    {
        StartCoroutine(Begin());
    }


    IEnumerator Begin()
    {
        yield return new WaitForSeconds(10f);
        movingup = false;
        movingback = true;
     }
}

