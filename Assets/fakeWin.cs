using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class fakeWin : MonoBehaviour
{
    public bool Fake = true;
    int score = int.Parse(System.IO.File.ReadAllText(@"Assets/Scenes/score.txt"));
    public GameObject scoreText;
    public int scoreAdd = 120;
    void Start() {
        InvokeRepeating("scoreTime", 0f, 1f);
    }
    void OnCollisionEnter2D(Collision2D win) {
        if(Fake) {
            this.transform.position = new Vector3(-17.5f, -12.25f, -15f);
            GameObject.Find("antipiege trigger").GetComponent<Antipiege1Trigger>().Active = true;
            GameObject.Find("antipiege trigger").transform.position = new Vector3(GameObject.Find("antipiege trigger").transform.position.x, GameObject.Find("antipiege trigger").transform.position.y, -15);
            Fake = false;
            GameObject.Find("piegeEnBas").GetComponent<piegeEncore>().Active = true;
            GameObject.Find("piegeEnBas").transform.position = new Vector3(GameObject.Find("piegeEnBas").transform.position.x, GameObject.Find("piegeEnBas").transform.position.y, -15);

        } else {
            score += scoreAdd;
            SaveScore(score);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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

    void Update()
    {
        
    }
}
