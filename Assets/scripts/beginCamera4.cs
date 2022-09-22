using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beginCamera4 : MonoBehaviour
{

    public GameObject mainCamera;
    public GameObject rocket;
    // Update is called once per frame
    void FixedUpdate()
    {
        this.gameObject.transform.Rotate(0.0f, 0.2f, 0.0f, Space.Self);
        
        StartCoroutine("wfs3");
    }
    
    IEnumerator wfs3() {
    
       
       yield return new WaitForSeconds(7);
       
       mainCamera.SetActive(true);
       rocket.SetActive(true);
       this.gameObject.SetActive(false);
       
    }
}
