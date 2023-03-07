using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
struct FrictionType {
    public string key;
    public float FrictionVal;
}

public class PlayerMovement : MonoBehaviour
{
    private const float u = 0.0001f;

    //temp pub
    //start
    //end

    private float MaxSpeed = 3200f*u;
    private float MinStopSpeedValue = 1000f*u;
    private float CardinalForceMagnitude = 1000000f*u;
    private float MaxAccel;
    private FrictionType[] BaseFriction;

    public GameObject player;
    public GameObject camera;
    public Rigidbody PhysPlayer;
    [SerializeField]
    private InputActionReference movement;
    
    private float rotation;
    private float AdditionalSpeed;
    private float CurrentSpeed;
    private float[] jumpBuffer;
    private Vector3 velocity; 
    // create a mapping of the key binds from a json file [nofbinds (7), 2 (keycode)]
    
    // Start is called before the first frame update
    void Start()
    {
        jumpBuffer = new float[5];
        MaxAccel = 10 * MaxSpeed;
        BaseFriction = new FrictionType[2];
        BaseFriction[0].key = "Ground";
        BaseFriction[0].FrictionVal = 0.5f;

    }

    // Update is called once per frame
    void Update()
    {
        //store input buffer
        getInput();
        //get camera rotation X = Up and down and Y = Right and left (in degrees)
        // only need Y

        // returns rotation from 0 degrees to 360 degrees from the positive z direction anticlockwise looking from positive y axis
        rotation = player.transform.localRotation.eulerAngles.y;
        
        //call groundcheck
        bool isGrounded = groundCheck();
        //if grounded should employ resistance or make sure max velocity is kept
        if (isGrounded){
            // check if player is crouching
            GroundAccelerate(getwishdir(rotation));
        }
        else{
            // get relative wishdir

            AirAccelerate(getwishdir(rotation));
        }
        //if not grounded should call GroundAccelerate
        //player.transform.Translate(velocity.x,velocity.y,velocity.z);
        //camera.transform.Translate(velocity.x,velocity.y,velocity.z);
        
    }

    private void AirAccelerate(Vector3 wishdir)
    {
        Vector3 RigidbodyVel = PhysPlayer.velocity;
        CurrentSpeed = dot(ref RigidbodyVel, ref wishdir);
        AdditionalSpeed = clip(MaxSpeed - CurrentSpeed, 0, MaxAccel * (1/Time.deltaTime));
        PhysPlayer.velocity = RigidbodyVel + AdditionalSpeed * wishdir;
    }

    private void GroundAccelerate(Vector3 wishdir)
    {
        Vector3 RigidbodyVel = PhysPlayer.velocity;
        // call friction
        friction(ref RigidbodyVel, BaseFriction[0]);
        CurrentSpeed = dot(ref RigidbodyVel, ref wishdir);
        AdditionalSpeed = clip(MaxSpeed - CurrentSpeed, 0, MaxAccel * 1/Time.deltaTime) * u;
        PhysPlayer.velocity = RigidbodyVel + AdditionalSpeed * wishdir;
    }

    private bool groundCheck(){
        return true;
    }

    private void friction(ref UnityEngine.Vector3 velocity, FrictionType Friction)
    {
        float speedafterfriction, initialspeed, control;
        initialspeed = Mathf.Sqrt(Mathf.Pow(velocity.x,2) + Mathf.Pow(velocity.y,2) + Mathf.Pow(velocity.z,2));
        if (initialspeed == 0) {return;}
        control = (initialspeed < MinStopSpeedValue) ? MinStopSpeedValue : initialspeed;
        speedafterfriction = initialspeed - (Friction.FrictionVal * control);
        if (speedafterfriction < 0){
            speedafterfriction = 0;
        }
        speedafterfriction /= initialspeed;
        velocity *= speedafterfriction;
    }

    // returns a vector with magnitude CardinalForceMagnitude in the direction of the player's movement keys
    private UnityEngine.Vector3 getwishdir(float rotation)
    {
        //gives raw wishdir from keyboard input
        Vector2 rawWishdir = movement.action.ReadValue<Vector2>();
        Vector3 Wishdir = new Vector3 (rawWishdir.x, 0, rawWishdir.y);
        Wishdir.Normalize();
        Wishdir *= CardinalForceMagnitude;
        return Wishdir;
    }

    // for modifier e.g. shift walk, ctrl crouch, jump
    private void getInput(){
        
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
    private float dot(ref Vector3 a, ref Vector3 b)
    {
        return (a.x * b.x) + (a.y * b.y) + (a.z * b.z);
    }
}
