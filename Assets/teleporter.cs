using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D win) {
        player.transform.position = new Vector3(16.5f, 3f, player.transform.position.z);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
