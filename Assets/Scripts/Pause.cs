using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public GameObject PauseMenu;

    
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
         
            PauseMenu.SetActive(true);
        }
        if (Input.GetKey(KeyCode.C))
        {
            PauseMenu.SetActive(false);
            
        }


    }
}
