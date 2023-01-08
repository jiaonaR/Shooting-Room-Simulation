using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightintensity : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject whitelight;
    private Light thelight;
    public GameObject handbar;
    void Start()
    {
        thelight = whitelight.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        thelight.intensity =  handbar.transform.localPosition.y * 5f;
        thelight.range = handbar.transform.localPosition.y * 5f + 6;
    }
}
