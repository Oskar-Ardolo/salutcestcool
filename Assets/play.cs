using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button;
    void Start()
    {
        
    }
    public void Commencer() {
        System.IO.File.WriteAllText(@"Assets/Scenes/score.txt", "120");
        SceneManager.LoadScene("niveau1");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
