using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using Unity.Jobs;

public class GamespaceManager : MonoBehaviour
{
    [SerializeField]
    private int tickRate = 128;
    private float tickPeriod;
    private float time = 0.0f;
    // 128/s 1/128 s interval
    public Rigidbody rigidplayer;
    public GameObject player;
    //public GameObject camera;
    public GameObject Camera;
    //public static Unity.Jobs.JobHandle task(T jobData, Unity.Jobs.JobHandle dependant);
    // Start is called before the first frame update
    void Start()
    {
        tickPeriod = 1/tickRate;
        //public static Unity.Jobs.JobHandle Schedule(T jobData, Unity.Jobs.JobHandle dependant)
        
    }

    // Update is called once per frame
    void Update()
    {
        time += UnityEngine.Time.deltaTime;
        if (time >= tickPeriod){
            time = time - tickPeriod;
            // code runs tickRate per second

        }
    }
    
    
}
