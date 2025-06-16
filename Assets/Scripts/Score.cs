using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{

    public Transform player;
    public TextMeshProUGUI scoreText;
    private float startingZ;

    private void Start()
    {
        startingZ = player.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        float score = player.position.z - startingZ;
        scoreText.text = score.ToString("0");
    }
}
