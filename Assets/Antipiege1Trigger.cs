using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Antipiege1Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    public bool Active = false;

    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D e) {
        if(Active) {
            SceneManager.LoadScene("gameOver");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
