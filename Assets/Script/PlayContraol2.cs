using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayContraol2 : MonoBehaviour
{
    public float speed = 5.0f; 
    public float turnSpeed=25.0f;
    public float horizontalInput;
    public float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput= Input.GetAxis("Horizontal2");
        forwardInput= Input.GetAxis("Vertical2");

        
       transform.Translate(Vector3.forward*Time.deltaTime*speed * forwardInput);  
       if(forwardInput != 0){
        transform.Rotate(Vector3.up,Time.deltaTime*turnSpeed*horizontalInput);
       }
    }
}
