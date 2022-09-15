using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    GameObject rocket;
    public float speed_x;
    public float speed_y;
    public float speed_z;

    // Start is called before the first frame update
    void Start()
    {
        rocket = GameObject.Find("Rocket3");
    }

    // Update is called once per frame
    void Update()
    {
    
        var new_x = transform.position.x - Time.time * speed_x;
        var new_y = transform.position.y - Time.time * speed_y;
        var new_z = transform.position.z - Time.time * speed_z;

        // transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Min(new_z, 40));
        if (rocket.transform.position.y <= this.transform.position.y && rocket.transform.position.y >= 6) {
            this.gameObject.transform.Rotate(0.2f, 0.0f, 0.0f, Space.Self);
        }
        
        else if (rocket.transform.position.y <= 5 && transform.position.y >= 15) {
        
            // transform.position = new Vector3(new_x, transform.position.y, new_z);
            // transform.Rotate(0, 3.0f * Time.deltaTime, 0);
            transform.RotateAround(rocket.transform.position, Vector3.up, 20 * Time.deltaTime);
            transform.position = new Vector3(transform.position.x, new_y, transform.position.z);
        }
        
        else if (rocket.transform.position.y < 6) {
            
            // transform.position = Vector3.MoveTowards(transform.position, targ.transform.position, .03);
            if (transform.position.x > 32) {
                transform.position = new Vector3(new_x, transform.position.y, transform.position.z);
            }
            
            if (transform.position.z > 0) {
                transform.position = new Vector3(transform.position.x, transform.position.y, new_z);
            }
        }
        
    }
}
