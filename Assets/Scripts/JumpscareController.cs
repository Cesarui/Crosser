using UnityEngine;
using System.Collections;

public class JumpscareController : MonoBehaviour
{
    public GameObject jumpscareImage; 
    public AudioSource jumpscareAudio; 

    public void TriggerJumpscare(float duration = 2f)
    {
        jumpscareImage.SetActive(true);
        jumpscareAudio.Play();
        StartCoroutine(HideAfter(duration));
    }

    private IEnumerator HideAfter(float duration)
    {
        yield return new WaitForSeconds(duration);
        jumpscareImage.SetActive(false);
    }
}
