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
    private const float u = 0.05f;

    //temp pub
    //start
    public bool isground = false;
    //end
    private float MaxSpeed = 666f*u;
    private float MaxAccel;
    private float MinStopSpeedValue = 3f*u;
    private float MinSpeed = 1f*u;
    private FrictionType[] BaseFriction;

    public GameObject player;
    public GameObject camera;
    public Rigidbody PhysPlayer;
    public Collider Colide;
    [SerializeField]
    private PlayerInput PlayerInput;
    [SerializeField]
    private InputActionReference movement;
    [SerializeField]
    private InputActionReference Jump;
    
    private float rotation;
    private float AdditionalSpeed;
    private float CurrentSpeed;
    private float[] jumpBuffer;
    private Vector3 velocity; 
    
    // Start is called before the first frame update
    void Start()
    {
        jumpBuffer = new float[5];
        MaxAccel = 2 * MaxSpeed;
        BaseFriction = new FrictionType[2];
        BaseFriction[0].key = "Ground";
        BaseFriction[0].FrictionVal = 0.5f;
        // call read file from config folder, if custom binds defined load custom file specified

        // if not load default keybinds from json
    }

    // Update is called once per frame
    void Update()
    {
        isground = false;
        //check if player is dead


        //get camera rotation X = Up and down and Y = Right and left (in degrees)
        // only need Y

        // returns rotation from 0 degrees to 360 degrees from the positive z direction anticlockwise looking from positive y axis
        rotation = player.transform.localRotation.eulerAngles.y;
        
        //call groundcheck
        isground = groundCheck();
        //store input buffer
        getInput();
        //if grounded should employ resistance or make sure max velocity is kept
        if (isground){
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
        AdditionalSpeed = clip(MaxAccel * Time.deltaTime, 0, MaxSpeed - CurrentSpeed);
        PhysPlayer.velocity = RigidbodyVel + AdditionalSpeed * wishdir;
    }

    private void GroundAccelerate(Vector3 wishdir)
    {
        Vector3 RigidbodyVel = PhysPlayer.velocity;
        // call friction
        friction(ref RigidbodyVel, BaseFriction[0]);
        CurrentSpeed = dot(ref RigidbodyVel, ref wishdir);
        AdditionalSpeed = clip(MaxAccel * Time.deltaTime, 0, MaxSpeed - CurrentSpeed);
        // don't need to calculate if 0, early exit
        if(AdditionalSpeed == 0) {return;}
        PhysPlayer.velocity = RigidbodyVel + AdditionalSpeed * wishdir;
    }

    private bool groundCheck(){
        Ray ray = new ray(transform.position, Vector3.down * 0.2f);
        Physics.Raycast(ray, out RaycastHit hit);
        if(hit.collider.tag == "ground") { return true; }
        //return Physics.Raycast(transform.position, Vector3.down, 0.1f);
    }

    private void friction(ref UnityEngine.Vector3 velocity, FrictionType Friction)
    {
        float speedafterfriction, speed, control, drop;
        drop = 0;
        // get vector length
        speed = Mathf.Sqrt(Mathf.Pow(velocity.x,2) + Mathf.Pow(velocity.y,2) + Mathf.Pow(velocity.z,2));
        // early exit
        if (speed == 0) {return;}
        // check if speed below min speed threshold value e.g. if too slow
        if (speed < MinSpeed) {velocity *= 0; return;}
        control = (speed < MinStopSpeedValue) ? MinStopSpeedValue : speed;
        drop = speed - (Friction.FrictionVal * control) * Time.deltaTime;
        // scale velocity
        speedafterfriction = speed - drop;
        // make sure friction only opposes current movement
        if (speedafterfriction < 0){ speedafterfriction = 0; }
        if (speedafterfriction != speed)
        {
            // scale speed
            speedafterfriction /= speed;
            // scale velocity
            velocity *= speedafterfriction;
        }
    }

    // return a normalized vector in the direction of the player's movement keys
    private UnityEngine.Vector3 getwishdir(float rotation)
    {
        //gives raw wishdir from keyboard input
        Vector2 rawWishdir = movement.action.ReadValue<Vector2>();
        Vector3 Wishdir = new Vector3 (rawWishdir.x, 0, rawWishdir.y);
        Wishdir.Normalize();
        // get object rotation
        //rotation = Player.transform.localRotation.eulerAngles.y;
        rotation %= 360f;
        if(rotation >= 180f){
            rotation -= 360f;
        }
        // rotate vector by object rotation
        Wishdir = Quaternion.Euler(0,rotation,0) * Wishdir;
        return Wishdir;
    }

    // for Modifier e.g. shift walk, ctrl crouch, jump
    private void getInput()
    {
        if (PlayerInput.actions["Jump"].IsPressed() & isground){
            PhysPlayer.velocity = new Vector3(0,100000,0);
        }
    }

    private void jump()
    {

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
