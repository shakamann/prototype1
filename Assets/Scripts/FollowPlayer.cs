using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    //place the camera up  above and behind the  car 
    private Vector3 offset = new Vector3(0, 6, -15);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = player.transform.position;
        //transform.position = player.transform.position + offset;

    }
    // USE lateUpdate to move the camera only after the player moves to eliminate the jittery effct of moving player and camera at the same time
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
       
    }
}
