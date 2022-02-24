using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyoutofBoundaries : MonoBehaviour
{
    private float falllimit = -5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < falllimit) 
        {
            Destroy(gameObject); 
            FindObjectOfType<UIManager>().SetCountText();
            Debug.Log("Boundaries");
        }
    }
}
