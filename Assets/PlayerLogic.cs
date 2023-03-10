using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerLogic : MonoBehaviour
{
    [SerializeField]
    private int MaxHealth = 100;
    [SerializeField]
    private Camera Camera;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        health = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void castRay()
    {
        // create ray from the center of the viewport 
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        // debug for seeing the ray
        //Debug.DrawRay(ray.origin, ray.direction * 10);
        RaycastHit hitData;
        // draw the ray and output the properties to hitData
        if(Physics.Raycast(ray, out hitData))
        {
            // casted ray collided with something

        }
    }
}
