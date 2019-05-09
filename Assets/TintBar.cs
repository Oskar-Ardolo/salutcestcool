using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TintBar : MonoBehaviour
{
    public float delay;
    public float time;
    private bool state = true;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Clio", time, delay);
    }

    void Clio() {
        if(state) {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 15);
            state = false;
        } else {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -15);
            state = true;
        }
    }

    void OnTriggerEnter2D(Collider2D col) {
        if(state) {
            int score = int.Parse(System.IO.File.ReadAllText(@"Assets/Scenes/score.txt"));
            System.IO.File.WriteAllText(@"Assets/Scenes/score.txt", score.ToString());
            SceneManager.LoadScene("gameOver");
        }
    }
    void OnTriggerStay2D(Collider2D col) {
        if (state) {
            int score = int.Parse(System.IO.File.ReadAllText(@"Assets/Scenes/score.txt"));
            System.IO.File.WriteAllText(@"Assets/Scenes/score.txt", score.ToString());
            SceneManager.LoadScene("gameOver");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
