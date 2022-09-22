using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class initialCameraScript : MonoBehaviour
{

    public GameObject text0;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public GameObject text7;
    public GameObject text8;
    
    public GameObject beginningCamera3;
    // GameObject astronaut;
    
    // Start is called before the first frame update
    void Start() {    
        
        text0.SetActive(false);
        text1.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
        text4.SetActive(false);
        text5.SetActive(false);
        text6.SetActive(false);
        text7.SetActive(false);
        text8.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate() {

        this.gameObject.transform.Rotate(0.0f, 0.2f, 0.0f, Space.Self);
        
        StartCoroutine("wfs1");
    }
    
    IEnumerator wfs1() {
    
       
       yield return new WaitForSeconds(7);
       
       beginningCamera3.SetActive(true);
       this.gameObject.SetActive(false);
       
    }
}
