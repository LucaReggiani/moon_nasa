using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalCamera : MonoBehaviour
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
    
    
    // Update is called once per frame
    void FixedUpdate() {
        
        text0.transform.position = new Vector3(text0.transform.position.x, text0.transform.position.y + Time.time * 0.05f, text0.transform.position.z);
        text1.transform.position = new Vector3(text1.transform.position.x, text1.transform.position.y + Time.time * 0.05f, text1.transform.position.z);
        text2.transform.position = new Vector3(text2.transform.position.x, text2.transform.position.y + Time.time * 0.05f, text2.transform.position.z);
        text3.transform.position = new Vector3(text3.transform.position.x, text3.transform.position.y + Time.time * 0.05f, text3.transform.position.z);
        text4.transform.position = new Vector3(text4.transform.position.x, text4.transform.position.y + Time.time * 0.05f, text4.transform.position.z);
        text5.transform.position = new Vector3(text5.transform.position.x, text5.transform.position.y + Time.time * 0.05f, text5.transform.position.z);
        text6.transform.position = new Vector3(text6.transform.position.x, text6.transform.position.y + Time.time * 0.05f, text6.transform.position.z);
        text7.transform.position = new Vector3(text7.transform.position.x, text7.transform.position.y + Time.time * 0.05f, text7.transform.position.z);
        text8.transform.position = new Vector3(text8.transform.position.x, text8.transform.position.y + Time.time * 0.05f, text8.transform.position.z);
    }
}
