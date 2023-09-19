using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DropdownNav : MonoBehaviour
{

   
    public void LevelSelect(int val)
    {

        if (val == 0)
        {
            Debug.Log("Level needs to be selected");
        }
        if (val == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (val == 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);        
        }
        if (val == 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }





    }




















}


