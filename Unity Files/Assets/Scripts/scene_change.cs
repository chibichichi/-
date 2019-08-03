using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_change : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }


    void Update()
    {

    }

    public void clicked()
   {
     SceneManager.LoadScene("clicker_test");
   }
}
