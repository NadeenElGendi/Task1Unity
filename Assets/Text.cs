using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{ 
    public GameObject display;
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag=="Player")
        {
            display.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other){
        if (other.gameObject.tag=="Player")
        {
            display.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        display.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
