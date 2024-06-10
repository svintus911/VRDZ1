using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class SupportMove : MonoBehaviour
{
    public CircularDrive CD;
    private float assist_val;
    void Start()
    {
        assist_val = CD.linearMapping.value;
    }

    // Update is called once per frame
    void Update()
    {
        print(CD.linearMapping.value);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + LMChanging(CD.linearMapping.value));    
    }
    float LMChanging(float val)
    {
        float dif = 0;
        if(val!=assist_val)
        {
            dif = assist_val - val;
            assist_val=val;
        }
        return dif/10;
    }
}
