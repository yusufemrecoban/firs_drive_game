using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0,5,-7);
    private Vector3 offset2 = new Vector3(0,2.5f,2.5f);
    private Vector3 offset3 = new Vector3(0,5,-7);
    private int i=0; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        if(Input.GetKeyDown(KeyCode.Space)){
            
            offset=offset2;
            if(i%2==0){
                offset=offset3;
            }
            i++;
        }
        
        transform.position=player.transform.position+ offset ;
        transform.rotation=player.transform.rotation;
    }
}
