using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float multiplier = 1.5f;
    public Transform player;
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        float xPos = player.position.x;
        float positiveX = Mathf.Abs(xPos * multiplier);
        scoreText.text = positiveX.ToString("0");
    }
}
