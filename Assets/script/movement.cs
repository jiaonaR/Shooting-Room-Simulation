using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    public SteamVR_Action_Vector2 joystick;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movementDir = Player.instance.hmdTransform.TransformDirection(new Vector3(joystick.axis.x, 0, joystick.axis.y));
        transform.position += Vector3.ProjectOnPlane(Time.deltaTime * movementDir * 2f, Vector3.up);
    }
}
