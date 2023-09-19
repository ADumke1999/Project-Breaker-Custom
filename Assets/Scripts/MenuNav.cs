using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNav : MonoBehaviour
{


    //The other two buttons in the game are used to enable and disable the layers so to activate certain layers and disable others


    public void StartGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }



    public void QuitGame()
    {
        Debug.Log("The game has been quit.");
        Application.Quit();

    }


}
