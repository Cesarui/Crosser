using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject[] vehiclePrefabs;

    float startTime;

    [Header("Traffic Settings")]
    public CarDirection directionToSet;
    public float carSpeed;

    [Header("Timer Settings")]
    public float cooldown;

    private void Spawn(GameObject[] vehiclePrefabs)
    {
        int index = Random.Range(0, vehiclePrefabs.Length);

        GameObject newCar = Instantiate(vehiclePrefabs[index], transform.position, transform.rotation);

        DriveForward carScript = newCar.GetComponent<DriveForward>();

        carScript.myDirection = directionToSet;
        carScript.speed = carSpeed;
    }

    private void Start()
    {
        Spawn(vehiclePrefabs);
    }

    private void Update()
    {
        startTime += Time.deltaTime;

        if (startTime > cooldown)
        {
            Spawn(vehiclePrefabs);
            startTime -= cooldown;
        }
    }


}
