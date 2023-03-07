using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


//get camera rotation only need X = Up and down and Y = Right and left (in degrees)
// X goes to head, Y goes to entire player

public class MouseInput : MonoBehaviour
{
    // unity variables
    public GameObject Player;
    [SerializeField]
    private InputActionReference Mouselook;
    public float LookSensitivity = 1f;
    public bool InvertYAxis = false;
    public bool InvertXAxis = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 rawMouse = Mouselook.action.ReadValue<Vector2>();
        rawMouse *= LookSensitivity;
        //Player.Transform.Rotate();
    }
}
