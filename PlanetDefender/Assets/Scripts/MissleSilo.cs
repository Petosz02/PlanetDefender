using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleSilo : MonoBehaviour
{
    [SerializeField] private HomingMissle missle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FireMisle(Transform target){
        HomingMissle firedMisle = Instantiate(missle, this.transform.position, this.transform.rotation);
        firedMisle.target = target;
    }
}
