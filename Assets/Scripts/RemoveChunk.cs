using UnityEngine;

public class RemoveChunk : MonoBehaviour
{
    public GameObject lastChunk;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(lastChunk);
    }
}
