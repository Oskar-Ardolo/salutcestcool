using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antipiege1 : MonoBehaviour
{
    public GameObject piege;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D e) {
        GameObject.Find("antipiege trigger").GetComponent<Antipiege1Trigger>().Active = false;
        piege.transform.position = new Vector3(piege.transform.position.x, piege.transform.position.y, 15);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
