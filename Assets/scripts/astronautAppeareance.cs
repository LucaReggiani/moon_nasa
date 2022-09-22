using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class astronautAppeareance : MonoBehaviour
{

    public float speed_z;
    public GameObject flag;
    
    // Start is called before the first frame update
    void Start() {
    
    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        // move the rocket from the original position, until the ground
        var new_z = transform.position.z + Time.time * speed_z;
        
        if (transform.position.z <= 18.0) {
        
            transform.position = new Vector3(transform.position.x, transform.position.y, new_z);
        } else {

            StartCoroutine("Reseta");

        }
    }
    
    IEnumerator Reseta() {
    
       yield return new WaitForSeconds(8);
       
       flag.SetActive(true);
       
    }
    
}
