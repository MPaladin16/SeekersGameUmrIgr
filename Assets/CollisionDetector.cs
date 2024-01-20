using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.transform.name);
        Debug.Log(this.transform.parent.gameObject.tag);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        Debug.Log(this.transform.parent.gameObject.tag);
    }


}
