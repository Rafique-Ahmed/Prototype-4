using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 5.0f;


    private GameObject focalPoint;
    public int killcount;


    //Material code
    public Material[] material;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
        killcount=0;

        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        //playerRb.AddForce(Vector3.forward * speed * forwardInput);
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
        transform.localScale = new Vector3(1+killcount, 1+killcount, 1+killcount);
        if(killcount>=1){
        rend.sharedMaterial = material[killcount];


    }
    }

    public void killcountfunction(){
        killcount++;
    }
}