using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public GameObject rocket;
    public GameObject camera2;
    
    public float speed_x;
    public float speed_y;
    public float speed_z;

    // Update is called once per frame
    void FixedUpdate()
    {
    
        var new_x = transform.position.x - Time.time * speed_x;
        var new_y = transform.position.y - Time.time * speed_y;
        var new_z = transform.position.z - Time.time * speed_z;

        // transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Min(new_z, 40));
        if (rocket.transform.position.y <= this.transform.position.y && rocket.transform.position.y >= 6) {
            this.gameObject.transform.Rotate(0.3f, 0.0f, 0.0f, Space.Self);
        }
        
        else if (rocket.transform.position.y < 6) {
        
            if (transform.position.y >= 15) {
                transform.RotateAround(rocket.transform.position, Vector3.up, 20 * Time.deltaTime);
                transform.position = new Vector3(transform.position.x, new_y, transform.position.z);
            } else {
            
                StartCoroutine("wfsMainCamera");
            }
        }
        
    }
    
    IEnumerator wfsMainCamera() {
    
       
       yield return new WaitForSeconds(4);
       
       camera2.SetActive(true);
       this.gameObject.SetActive(false);
       
    }
}
