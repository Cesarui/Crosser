using UnityEngine;

public class SpawnChunk : MonoBehaviour
{
    public GameObject chunk;

    public GameObject lastChunk;

    public GameObject finalChunk;

    public int minusAmount;

    public int chunkCounter = 0;
    public int maxChunkAmount = 12;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && chunkCounter < maxChunkAmount)
        {
            chunkCounter++;
            Instantiate(chunk, new Vector3(chunk.transform.position.x - minusAmount, 0, 0), chunk.transform.rotation);
            lastChunk = chunk;
            Debug.Log(chunkCounter.ToString());
        }
        else if(other.tag == "Player" && chunkCounter == 12)
        {
            Instantiate(finalChunk, new Vector3(-519, -0.58f, -14f), chunk.transform.rotation);
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
