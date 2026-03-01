using UnityEngine;
using UnityEngine.SceneManagement;

public class CarCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("You Died");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
