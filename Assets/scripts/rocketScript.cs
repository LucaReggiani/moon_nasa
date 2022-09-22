using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketScript : MonoBehaviour
{
    
    public GameObject astronaut;
    public float speed;
    public float min_height;
    
    IEnumerator Reset() {
       
       yield return new WaitForSeconds(2);
       
       astronaut.SetActive(true);
       
    } 

    // Update is called once per frame
    void FixedUpdate() {
    
        
        // move the rocket from the original position, until the ground
        transform.position = new Vector3(transform.position.x, Mathf.Max(transform.position.y - Time.time * speed, min_height), transform.position.z);
        
        if (transform.position.y <= min_height) {
                
                StartCoroutine("Reset");
            
        }
        
    }
}
