using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroEnemy : MonoBehaviour
{

    [SerializeField]private float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime,0 ,0 );
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Bolha"))Destroy(gameObject);
    }
}
