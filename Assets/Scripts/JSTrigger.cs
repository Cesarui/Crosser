using UnityEngine;

public class JSTrigger : MonoBehaviour
{
    private JumpscareController controller;

    private void Start()
    {
        controller = FindFirstObjectByType<JumpscareController>();
        if (controller == null)
            Debug.LogError("No JumpscareController found in the scene!");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            controller.TriggerJumpscare();
        }
    }
}