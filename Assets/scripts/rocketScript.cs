using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketScript : MonoBehaviour
{
    
    GameObject astronaut;
    public float speed;
    public float min_height;
    
    // Start is called before the first frame update
    void Start() {
    
        astronaut = GameObject.Find("Jumping");
    
        astronaut.SetActive(false);        
    }
    
    public float get_position_x() {
    
        return transform.position.x;
    }
    
    public float get_position_y() {
    
        return transform.position.y;
    }
    
    public float get_position_z() {
    
        return transform.position.z;
    }
    
    IEnumerator Reset() {
    
        Debug.Log("I am here");
       
       yield return new WaitForSeconds(2);
       
       astronaut.SetActive(true);
       
       Debug.Log("I am here after await");
       
    } 

    // Update is called once per frame
    void Update() {
    
        
        // move the rocket from the original position, until the ground
        transform.position = new Vector3(transform.position.x, Mathf.Max(transform.position.y - Time.time * speed, min_height), transform.position.z);
        
        if (transform.position.y <= min_height) {
            
                
                StartCoroutine("Reset");
            
        }
        
    }
}
