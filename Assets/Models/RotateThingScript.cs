using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class RotateThingScript : MonoBehaviour
{
    public GameObject RotateThing;
    private int speed;
    public CircularDrive CD;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateThing.transform.Rotate(0, CD.linearMapping.value, 0);
    }
}
