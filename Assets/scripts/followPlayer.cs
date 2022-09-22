using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class followPlayer : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public GameObject finalCamera;
    
    // Start is called before the first frame update
    void Start() {
    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = target.position + offset;
        transform.rotation = Quaternion.Euler(30, target.rotation.y, 0);
        StartCoroutine("wfs5");
    }
    
    IEnumerator wfs5() {
    
       yield return new WaitForSeconds(23);
       
       finalCamera.SetActive(true);
       this.gameObject.SetActive(false);
       
    }
}
