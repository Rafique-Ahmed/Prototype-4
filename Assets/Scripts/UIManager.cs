using System.Collections;
using System.Collections.Generic;
using UnityEngine;



using TMPro;
public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI killtext;
    public int killcount=0;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetCountText(){
        killcount = killcount+1;
	    killtext.text = "Count: " + killcount.ToString();
        FindObjectOfType<PlayerController>().killcountfunction();
	}
}
