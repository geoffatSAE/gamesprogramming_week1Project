using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeasureDistance : MonoBehaviour
{
    public Transform otherGO;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Distance to other using Vector3 is : " + Vector3.Distance(transform.position, otherGO.position));

        float x = Mathf.Pow((transform.position.x - otherGO.position.x), 2);
        float y = Mathf.Pow((transform.position.y - otherGO.position.y), 2);
        float z = Mathf.Pow((transform.position.z - otherGO.position.z), 2);
        float sq = x + y + z;
        Debug.Log("Distance to other using calulation is : " + Mathf.Sqrt(sq));
    }
}
