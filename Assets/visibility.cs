using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visibility : MonoBehaviour
{
    public GameObject cylinder;

    public void hide() {
        cylinder.SetActive(false);
    }
    public void show() {
        cylinder.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
