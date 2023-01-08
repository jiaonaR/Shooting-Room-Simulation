using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifttarget : MonoBehaviour
{
    public GameObject upper;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
      
        upper.SendMessage("rollup");
    
    }
    void OnTriggerExit(Collider other)
    {
        upper.SendMessage("rolldown");

    }
}
