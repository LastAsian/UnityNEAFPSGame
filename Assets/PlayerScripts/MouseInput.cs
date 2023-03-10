using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


//get camera rotation only need X = Up and down and Y = Right and left (in degrees)
// X goes to head, Y goes to entire player

public class MouseInput : MonoBehaviour
{
    // unity variables
    [SerializeField]
    private GameObject Player;
    [SerializeField]
    private GameObject Camera;
    [SerializeField]
    private InputActionReference Mouselook;
    public float LookSensitivity = 10f;
    public bool InvertYAxis = false;
    public bool InvertXAxis = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if input is grabbed lock cursor and hide
        grabInput(true);
        Vector2 rawMouse = Mouselook.action.ReadValue<Vector2>();
        rawMouse *= LookSensitivity * Time.deltaTime;
        Player.transform.Rotate(0,rawMouse.x,0);
        float rotation = Camera.transform.localRotation.eulerAngles.x;
        rotation %= 360f;
        if(rotation >= 180f){
            rotation -= 360f;
        }
        if((rotation - rawMouse.y <= 90f) && (rotation - rawMouse.y >= -90f))
            Camera.transform.Rotate(-rawMouse.y,0,0);

    }

    void grabInput(bool toggle)
    {
        if (toggle)
        {
            Screen.lockCursor = true;
            Cursor.visible = false;
        }
        else
        {
            Screen.lockCursor = false;
            Cursor.visible = true;
        }
    }
    private float clip(float value, float value_min, float value_max)
    {
        if (value < value_min){
            return value_min;
        }
        else if (value > value_min){
            return value_max;
        }
        else{
            return value;
        }
    }
}
