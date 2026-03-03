using UnityEngine;

public class StopMusicTrigger : MonoBehaviour
{
    public GameObject ambientSoundPrefab;

    private void OnTriggerEnter(Collider other)
    {
        AudioSource[] allSources = Object.FindObjectsByType<AudioSource>(FindObjectsSortMode.None);

        foreach (AudioSource source in allSources)
        {
            source.Stop();
        }
        GameObject audioObj = Instantiate(ambientSoundPrefab, transform.position, Quaternion.identity);
        AudioSource audio = audioObj.GetComponent<AudioSource>();
        audio.Play();

        Destroy(audioObj, audio.clip.length);
    }
}
