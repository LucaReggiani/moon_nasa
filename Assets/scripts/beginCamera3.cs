using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beginCamera3 : MonoBehaviour
{

    public GameObject beginningCamera3;

    // Update is called once per frame
    void FixedUpdate()
    {
        this.gameObject.transform.Rotate(0.0f, 0.2f, 0.0f, Space.Self);
        
        StartCoroutine("wfs2");
    }
    
    IEnumerator wfs2() {
    
       
       yield return new WaitForSeconds(7);
       
       beginningCamera3.SetActive(true);
       this.gameObject.SetActive(false);
       
    }
}
