using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_movement : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D.velocity = new Vector3(+speed,0,2);
        Destroy(gameObject,1f);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("enemy")){
            if(other.GetComponent<enemy_death>().dead==false){
                other.GetComponent<enemy_death>().hit();
                Destroy(gameObject);
            }
        }
    }
}