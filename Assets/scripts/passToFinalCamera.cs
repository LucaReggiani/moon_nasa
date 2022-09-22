using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class passToFinalCamera : MonoBehaviour
{
    public GameObject finalText0;
    public GameObject finalText1;
    public GameObject finalText2;
    public GameObject finalText3;
    public GameObject finalText4;
    public GameObject finalText5;
    public GameObject finalText6;
    public GameObject finalText7;
    public GameObject finalText8;
    
    public GameObject finalCameraText;

    // Update is called once per frame
    void FixedUpdate()
    {
       StartCoroutine("wfs8");
    }
    
    IEnumerator wfs8() {
    
       yield return new WaitForSeconds(10);
       finalText0.SetActive(true);
       finalText1.SetActive(true);
       finalText2.SetActive(true);
       finalText3.SetActive(true);
       finalText4.SetActive(true);
       finalText5.SetActive(true);
       finalText6.SetActive(true);
       finalText7.SetActive(true);
       finalText8.SetActive(true);
       finalCameraText.SetActive(true);
       
       this.gameObject.SetActive(false);
       
    }
}
