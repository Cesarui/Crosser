using UnityEngine;

public class SpawnChunk : MonoBehaviour
{
    public GameObject chunk;

    public GameObject lastChunk;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Instantiate(chunk, new Vector3(chunk.transform.position.x - 45, 0, 0), chunk.transform.rotation);

            lastChunk = chunk;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(lastChunk);
        }
    }
}
