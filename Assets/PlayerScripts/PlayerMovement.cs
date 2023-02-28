using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public GameObject camera;
    private string json;
    private float[] inputBuffer;
    private const float u = 0.00001f;
    private Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        inputBuffer = new float[5];
        //using(StreamReader file = file.ReadAllText("./Keybinds.json"));
        velocity = new Vector3(0u,0u,1u);
    }

    // Update is called once per frame
    void Update()
    {
        //store input buffer
        //call groundcheck

        //if grounded should employ resistance or make sure max velocity is kept
        

        //if not grounded should call GroundAccelerate
        player.transform.Translate(velocity.x,velocity.y,velocity.z);
        camera.transform.Translate(velocity.x,velocity.y,velocity.z);
        
    }

    private void AirAccelerate(Vector3 wishdir, float wishspeed, float AirAccelerate)
    {

    }

    private void GroundAccelerate(Vector3 wishdir, float wishspeed, float AirAccelerate)
    {

    }

    bool groundCheck(){
        return true;
    }

}
