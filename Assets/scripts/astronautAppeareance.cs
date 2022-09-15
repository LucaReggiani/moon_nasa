using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class astronautAppeareance : MonoBehaviour
{

    public float speed_x;
    public float speed_z;
    
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
        // move the rocket from the original position, until the ground
        var new_x = transform.position.x - Time.time * speed_x;
        var new_z = transform.position.z + Time.time * speed_z;
        Debug.Log(Time.time);
        transform.position = new Vector3(transform.position.x, transform.position.y, new_z);
    }
    
}
