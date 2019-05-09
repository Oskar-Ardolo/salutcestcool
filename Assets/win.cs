using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class win : MonoBehaviour {
    // Start is called before the first frame update
    int score = int.Parse(System.IO.File.ReadAllText(@"Assets/Scenes/score.txt"));
    public GameObject scoreText;
    public int scoreAdd = 120;
    void Start() {
        InvokeRepeating("scoreTime", 0f, 1f);
    }

    private void OnCollisionEnter2D(Collision2D win) {
        if (win.gameObject.name == "player") {
            score += scoreAdd;
            SaveScore(score);
            if(SceneManager.sceneCountInBuildSettings != SceneManager.GetActiveScene().buildIndex + 1) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            } else {
                SceneManager.LoadScene("win");
            }
            
        }
    }

    private void scoreTime() {
        score--;
        scoreText.GetComponent<Text>().text = score.ToString();
        if (score == 0) {
            SceneManager.LoadScene("gameOver");
        }
        SaveScore(score);
    }
    public static void SaveScore(int scoreSave) {
        System.IO.File.WriteAllText(@"Assets/Scenes/score.txt", scoreSave.ToString());
    }

    // Update is called once per frame
    void Update() {

    }
}
