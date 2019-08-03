using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class image_scale : MonoBehaviour
{
    // Start is called before the first frame update
   
    private float imgw, imgh, imgr, scnr;
    void Start()
    {
        imgw = transform.gameObject.GetComponent<RectTransform>().rect.width;
        imgh = transform.gameObject.GetComponent<RectTransform>().rect.height;
        imgr = imgh/imgw;
        scnr = Screen.height/Screen.width;
        Vector2 myVector = new Vector2();
        if(imgr >= scnr)
        {
            myVector = new Vector2(Screen.width,Screen.width*imgr);
        }
        else
        {
            myVector = new Vector2(Screen.height/imgr,Screen.height);
        } 
    
        transform.gameObject.GetComponent<RectTransform>().sizeDelta = myVector;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
