using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piegeActivateur : MonoBehaviour
{
    public bool Active = false;
    public GameObject piege1;
    public GameObject piege2;
    public GameObject sahQuelPlaisir;
    private bool state = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D win) {
        StartCoroutine("Piege");
    }
    IEnumerator Piege() {
        if(state) {
            piege1.transform.position = new Vector3(piege1.transform.position.x, piege1.transform.position.y, -15);
            piege2.transform.position = new Vector3(piege2.transform.position.x, piege2.transform.position.y, -15);
            Active = true;
            sahQuelPlaisir.transform.position = new Vector3(sahQuelPlaisir.transform.position.x, sahQuelPlaisir.transform.position.y, -15);
            yield return new WaitForSeconds(4);
            sahQuelPlaisir.transform.position = new Vector3(sahQuelPlaisir.transform.position.x, sahQuelPlaisir.transform.position.y, 50);
            state = false;
            yield return null;
        }
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
