using UnityEngine;

public class HeadBob : MonoBehaviour
{
    [Header("Settings")]
    public float walkBobSpeed = 14f;
    public float bobAmount = 0.05f;
    public PlayerMovement playerMovement; // We need to know if the player is moving

    private float timer = 0f;
    private float defaultYPos = 0f;

    void Start()
    {
        // Remember where the camera started
        defaultYPos = transform.localPosition.y;
    }

    void Update()
    {
        // 1. Check if the player is actually moving on the ground
        // We check the Rigidbody velocity to see if they are walking
        float moveSpeed = new Vector3(playerMovement.GetComponent<Rigidbody>().linearVelocity.x, 0, playerMovement.GetComponent<Rigidbody>().linearVelocity.z).magnitude;

        if (moveSpeed > 0.1f)
        {
            // 2. The player is moving! Spin the "Ferris Wheel"
            timer += Time.deltaTime * walkBobSpeed;

            // 3. Calculate the new Y position using Sine
            float newY = defaultYPos + Mathf.Sin(timer) * bobAmount;

            // 4. Apply it to the camera
            transform.localPosition = new Vector3(transform.localPosition.x, newY, transform.localPosition.z);
        }
        else
        {
            // 5. Player stopped? Smoothly reset the camera to the middle
            timer = 0;
            transform.localPosition = new Vector3(transform.localPosition.x, Mathf.Lerp(transform.localPosition.y, defaultYPos, Time.deltaTime * 10f), transform.localPosition.z);
        }
    }
}
