using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Score multiplier
    public float multiplier = 1.5f;
    public Transform player;
    public TextMeshProUGUI scoreText;
    float xPos;
    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        xPos = player.position.x;
        float positiveX = Mathf.Abs(xPos * multiplier);
        scoreText.text = positiveX.ToString("0m");
    }
}
