using UnityEngine;

public class SpawnChunk : MonoBehaviour
{
    public GameObject chunk;

    public GameObject lastChunk;

    public int chunkCounter = 0;
    public int maxChunkAmount = 12;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && chunkCounter < maxChunkAmount)
        {
            chunkCounter++;
            Instantiate(chunk, new Vector3(chunk.transform.position.x - 45, 0, 0), chunk.transform.rotation);

            lastChunk = chunk;
            Debug.Log(chunkCounter.ToString());
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
