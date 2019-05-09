using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class playagain : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject scoreText;
    public GameObject bestScoreText;

    void Start()
    {
        int score = int.Parse(System.IO.File.ReadAllText(@"Assets/Scenes/score.txt"));  
        scoreText.GetComponent<Text>().text = score.ToString();

        int bestScore = int.Parse(System.IO.File.ReadAllText(@"Assets/Scenes/bestScore.txt"));
        bestScoreText.GetComponent<Text>().text = bestScore.ToString();

        if(score > bestScore) {
            bestScoreText.GetComponent<Text>().text = score.ToString();
            System.IO.File.WriteAllText(@"Assets/Scenes/bestScore.txt", score.ToString());

        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0)) {
            System.IO.File.WriteAllText(@"Assets/Scenes/score.txt", "120");
            SceneManager.LoadScene("niveau1");
        }
        if(Input.anyKey) {
            System.IO.File.WriteAllText(@"Assets/Scenes/score.txt", "120");
            SceneManager.LoadScene("niveau1");
        }

    }

}
