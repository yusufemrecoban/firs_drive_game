using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCont : MonoBehaviour
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
        horizontalInput= Input.GetAxis("Horizontal");
        forwardInput= Input.GetAxis("Vertical");

        
       transform.Translate(Vector3.forward*Time.deltaTime*speed * forwardInput);  
       if(forwardInput != 0){
        transform.Rotate(Vector3.up,Time.deltaTime*turnSpeed*horizontalInput);
       }
       
    }
}
