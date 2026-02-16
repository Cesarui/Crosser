using UnityEngine;

public enum CarDirection { Forward, Backward }

public class DriveForward : MonoBehaviour
{
    public CarDirection myDirection;

    [Header("Movement Settings")]
    public float speed;

    void checkForFloor()
    {
        if(transform.position.y < -0f)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        checkForFloor();

        if(myDirection == CarDirection.Forward)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else if(myDirection == CarDirection.Backward)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

    }
}
