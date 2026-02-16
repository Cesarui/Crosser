using UnityEngine;

public class CarDespawner : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Car")
        {
            Destroy(other.gameObject);
        }
    }
}
