using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class niveau2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D win) {
        if (win.gameObject.name == "player") {
            SceneManager.LoadScene("niveau2", LoadSceneMode.Additive);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
