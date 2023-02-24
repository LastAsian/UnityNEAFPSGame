using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    // unity variables
    [Tooltip("Sensitivity multiplier for moving the camera around")]
    public float LookSensitivity = 1f;

    [Tooltip("Additional sensitivity multiplier for WebGL")]
    public float WebglLookSensitivityMultiplier = 0.25f;
    [Tooltip("Limit to consider an input when using a trigger on a controller")]
    public float TriggerAxisThreshold = 0.4f;
    [Tooltip("Used to flip the vertical input axis")]
    public bool InvertYAxis = false;
    [Tooltip("Used to flip the horizontal input axis")]
    public bool InvertXAxis = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
