using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class piegeActiveLv3 : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {

    }

    private void OnTriggerEnter2D(Collider2D win) {
        if (GameObject.Find("piegeActivateur1").GetComponent<piegeActivateur>().Active) {
            if (win.gameObject.name == "player") {
                int score = int.Parse(System.IO.File.ReadAllText(@"Assets/Scenes/score.txt"));
                System.IO.File.WriteAllText(@"Assets/Scenes/score.txt", score.ToString());
                SceneManager.LoadScene("gameOver");
            }
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
