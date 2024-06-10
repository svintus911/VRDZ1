using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class SpeedControl : MonoBehaviour
{
    public GameObject Spindel;
    private int speed;
    public CircularDrive CD;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Spindel.transform.Rotate(0,CD.linearMapping.value, 0);
    }
}
