using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initialPresentationCamera : MonoBehaviour
{

    public GameObject initialCamera;
    public GameObject mainCamera;
    public GameObject camera2;
    public GameObject beginningCamera3;
    public GameObject beginningCamera4;
    public GameObject finalCamera;
    public GameObject finalCameraText;
    public GameObject rocket;
    public GameObject astronaut;
    public GameObject flag;
    public GameObject text0;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public GameObject text7;
    public GameObject text8;
    
    public GameObject finalText0;
    public GameObject finalText1;
    public GameObject finalText2;
    public GameObject finalText3;
    public GameObject finalText4;
    public GameObject finalText5;
    public GameObject finalText6;
    public GameObject finalText7;
    public GameObject finalText8;


    void Start() {    
        
        initialCamera.SetActive(false);
        mainCamera.SetActive(false);
        camera2.SetActive(false);
        beginningCamera3.SetActive(false);
        beginningCamera4.SetActive(false);
        rocket.SetActive(false);
        astronaut.SetActive(false);  
        finalCamera.SetActive(false);
        finalCameraText.SetActive(false);
        flag.SetActive(false);
        
        finalText0.SetActive(false);
        finalText1.SetActive(false);
        finalText2.SetActive(false);
        finalText3.SetActive(false);
        finalText4.SetActive(false);
        finalText5.SetActive(false);
        finalText6.SetActive(false);
        finalText7.SetActive(false);
        finalText8.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        text0.transform.position = new Vector3(text0.transform.position.x, text0.transform.position.y + Time.time * 0.2f, text0.transform.position.z);
        text1.transform.position = new Vector3(text1.transform.position.x, text1.transform.position.y + Time.time * 0.2f, text1.transform.position.z);
        text2.transform.position = new Vector3(text2.transform.position.x, text2.transform.position.y + Time.time * 0.2f, text2.transform.position.z);
        text3.transform.position = new Vector3(text3.transform.position.x, text3.transform.position.y + Time.time * 0.2f, text3.transform.position.z);
        text4.transform.position = new Vector3(text4.transform.position.x, text4.transform.position.y + Time.time * 0.2f, text4.transform.position.z);
        text5.transform.position = new Vector3(text5.transform.position.x, text5.transform.position.y + Time.time * 0.2f, text5.transform.position.z);
        text6.transform.position = new Vector3(text6.transform.position.x, text6.transform.position.y + Time.time * 0.2f, text6.transform.position.z);
        text7.transform.position = new Vector3(text7.transform.position.x, text7.transform.position.y + Time.time * 0.2f, text7.transform.position.z);
        text8.transform.position = new Vector3(text8.transform.position.x, text8.transform.position.y + Time.time * 0.2f, text8.transform.position.z);
        
        StartCoroutine("wfs0");
    }
    
    IEnumerator wfs0() {
    
       
       yield return new WaitForSeconds(25);
       
       initialCamera.SetActive(true);
       this.gameObject.SetActive(false);
       
    }
}
