using UnityEngine;
using TMPro;

public class scoreScript : MonoBehaviour
{
    private static int score = 0;
    private static GameObject txtScore;
    // Start is called before the first frame update
    void Start()
    {
        txtScore = GameObject.Find("txtScore");
    }

    public static void scoreIncrement(int increment)
    {
        score += increment;
        txtScore.GetComponent<TMP_Text>().text = "Placar: " + score;
    }

}
