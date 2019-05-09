using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class piegeEncore : MonoBehaviour
{
    // Start is called before the first frame update
    public bool Active = false;
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D e) {
        if (Active) {
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
