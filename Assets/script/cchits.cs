using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cchits : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject particle;
    private int hits = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        hits = hits +1;
        if (other.tag == "light")
        {

            Debug.Log(hits);

        }



    }
}
