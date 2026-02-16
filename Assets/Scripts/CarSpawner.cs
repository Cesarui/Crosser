using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;

    float startTime;

    [Header("Traffic Settings")]
    public CarDirection directionToSet;
    public float carSpeed;

    [Header("Timer Settings")]
    public float cooldown;

    private void Spawn(GameObject obj)
    {
        GameObject newCar = Instantiate(obj, transform.position, transform.rotation);

        DriveForward carScript = newCar.GetComponent<DriveForward>();

        carScript.myDirection = directionToSet;
        carScript.speed = carSpeed;
    }

    private void Start()
    {
        Spawn(objectToSpawn);
    }

    private void Update()
    {
        startTime += Time.deltaTime;

        if (startTime > cooldown)
        {
            Spawn(objectToSpawn);
            startTime -= cooldown;
        }
    }


}
