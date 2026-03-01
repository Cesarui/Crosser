using UnityEngine;

public class CarCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("You Died");
            other.gameObject.GetComponentInParent<Rigidbody>().AddForce(10000, 10000, 10000, ForceMode.Acceleration);
        }
    }
}
