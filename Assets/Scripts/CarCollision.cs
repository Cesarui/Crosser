using UnityEngine;
using UnityEngine.SceneManagement;

public class CarCollision : MonoBehaviour
{
    public GameObject crashAudioPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            GameObject audioObj = Instantiate(crashAudioPrefab, transform.position, Quaternion.identity);
            AudioSource audio = audioObj.GetComponent<AudioSource>();
            audio.Play();
            
            Destroy(audioObj, audio.clip.length);
        }
    }
}
