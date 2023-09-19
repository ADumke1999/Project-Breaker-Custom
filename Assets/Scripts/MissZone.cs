using UnityEngine;
using UnityEngine.SceneManagement;

public class MissZone : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        FindObjectOfType<GameManager>().Miss();
        
    }

    

}
