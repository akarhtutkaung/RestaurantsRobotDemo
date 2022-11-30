using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoronoiMovement : MonoBehaviour
{
    private List<Vector3> voronoi = new List<Vector3>() { 
        new Vector3(2.7f, 0f, 17.9f),
        new Vector3(3.4f, 0f, 17.9f),
        new Vector3(4.1f, 0f, 17.9f),
        new Vector3(4.8f, 0f, 17.9f),
        new Vector3(5.5f, 0f, 17.9f),
        new Vector3(6.2f, 0f, 17.9f),
        new Vector3(6.9f, 0f, 17.8f),
        new Vector3(7.0f, 0f, 17.1f),
        new Vector3(7.0f, 0f, 16.4f),
        new Vector3(7.0f, 0f, 15.7f),
        new Vector3(7.0f, 0f, 15.0f),
        new Vector3(7.0f, 0f, 14.3f),
        new Vector3(7.0f, 0f, 13.6f),
        new Vector3(7.3f, 0f, 13.0f),
        new Vector3(7.0f, 0f, 12.4f),
        new Vector3(7.0f, 0f, 11.7f),
        new Vector3(7.0f, 0f, 11.0f),
        new Vector3(7.0f, 0f, 10.3f),
        new Vector3(7.0f, 0f, 9.6f),
        new Vector3(7.3f, 0f, 9.0f),
        new Vector3(8.0f, 0f, 9.0f),
        new Vector3(8.7f, 0f, 9.0f),
        new Vector3(9.4f, 0f, 9.0f),
        new Vector3(10.1f, 0f, 9.0f),
        new Vector3(10.8f, 0f, 9.0f),
        new Vector3(11.0f, 0f, 8.4f),
        new Vector3(11.0f, 0f, 7.7f),
        new Vector3(11.0f, 0f, 7.0f),
        new Vector3(11.0f, 0f, 6.3f),
        new Vector3(11.0f, 0f, 5.6f),
        new Vector3(11.0f, 0f, 4.9f),
        new Vector3(11.0f, 0f, 4.2f),
        new Vector3(11.0f, 0f, 3.5f),
        new Vector3(11.0f, 0f, 3.0f),
        new Vector3(11.0f, 0f, 3.0f),
        new Vector3(11.9f, 0f, 3.0f)
    };
    int countPos = 0;
    Vector3 angle;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        angle = transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        if(countPos < voronoi.Count){
            if(Vector3.Distance(voronoi[countPos], transform.position) < 1){
                countPos++;
            } else {
                Vector3 dir = Vector3.Normalize(voronoi[countPos] - transform.position);
                Vector3 vel = dir * speed * Time.deltaTime;
                transform.position = transform.position + vel;

                // Rotation of the agent
                angle = (0.95f*angle)+(0.05f*dir * speed);
                transform.rotation = Quaternion.LookRotation(angle, Vector3.up); 
            }
        }
    }
}
