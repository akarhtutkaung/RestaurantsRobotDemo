using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrmMovement : MonoBehaviour
{
    private List<Vector3> prm = new List<Vector3>() { 
        new Vector3(2.1f, 0f, 18.0f),
        new Vector3(2.2f, 0f, 18.0f),
        new Vector3(2.3f, 0f, 18.0f),
        new Vector3(2.4f, 0f, 18.0f),
        new Vector3(2.5f, 0f, 18.0f),
        new Vector3(2.6f, 0f, 18.0f),
        new Vector3(2.6f, 0f, 18.0f),
        new Vector3(2.7f, 0f, 18.0108f),
        new Vector3(2.8f, 0f, 18.0217f),
        new Vector3(2.9f, 0f, 18.0325f),
        new Vector3(3.0f, 0f, 18.0434f),
        new Vector3(3.1f, 0f, 18.0542f),
        new Vector3(3.2f, 0f, 18.0651f),
        new Vector3(3.3f, 0f, 18.0759f),
        new Vector3(3.4f, 0f, 18.0867f),
        new Vector3(3.5f, 0f, 18.0976f),
        new Vector3(3.6f, 0f, 18.1084f),
        new Vector3(3.7f, 0f, 18.1193f),
        new Vector3(3.8f, 0f, 18.1301f),
        new Vector3(3.9f, 0f, 18.141f),
        new Vector3(4.0f, 0f, 18.1518f),
        new Vector3(4.1f, 0f, 18.1627f),
        new Vector3(4.2f, 0f, 18.1735f),
        new Vector3(4.3f, 0f, 18.1843f),
        new Vector3(4.4f, 0f, 18.1952f),
        new Vector3(4.5f, 0f, 18.206f),
        new Vector3(4.6f, 0f, 18.2169f),
        new Vector3(4.7f, 0f, 18.2277f),
        new Vector3(4.8f, 0f, 18.2386f),
        new Vector3(4.9f, 0f, 18.2494f),
        new Vector3(5.0f, 0f, 18.2602f),
        new Vector3(5.1f, 0f, 18.2711f),
        new Vector3(5.2f, 0f, 18.2819f),
        new Vector3(5.3f, 0f, 18.2928f),
        new Vector3(5.4f, 0f, 18.3036f),
        new Vector3(5.5f, 0f, 18.3145f),
        new Vector3(5.6f, 0f, 18.3253f),
        new Vector3(5.7f, 0f, 18.3361f),
        new Vector3(5.8f, 0f, 18.347f),
        new Vector3(5.9f, 0f, 18.3578f),
        new Vector3(6.0f, 0f, 18.3687f),
        new Vector3(6.1f, 0f, 18.3795f),
        new Vector3(6.2f, 0f, 18.3904f),
        new Vector3(6.3f, 0f, 18.4012f),
        new Vector3(6.4f, 0f, 18.412f),
        new Vector3(6.5f, 0f, 18.4229f),
        new Vector3(6.6f, 0f, 18.4337f),
        new Vector3(6.7f, 0f, 18.4446f),
        new Vector3(6.8f, 0f, 18.4554f),
        new Vector3(6.9f, 0f, 18.4663f),
        new Vector3(7.0f, 0f, 18.4771f),
        new Vector3(7.1f, 0f, 18.488f),
        new Vector3(7.2f, 0f, 18.4988f),
        new Vector3(7.3f, 0f, 18.5096f),
        new Vector3(7.4f, 0f, 18.5205f),
        new Vector3(7.5f, 0f, 18.5313f),
        new Vector3(7.6f, 0f, 18.5422f),
        new Vector3(7.7f, 0f, 18.553f),
        new Vector3(7.8f, 0f, 18.5639f),
        new Vector3(7.9f, 0f, 18.5747f),
        new Vector3(8.0f, 0f, 18.5855f),
        new Vector3(8.1f, 0f, 18.5964f),
        new Vector3(8.2f, 0f, 18.6072f),
        new Vector3(8.3f, 0f, 18.6181f),
        new Vector3(8.4f, 0f, 18.6289f),
        new Vector3(8.5f, 0f, 18.6398f),
        new Vector3(8.6f, 0f, 18.6506f),
        new Vector3(8.7f, 0f, 18.6614f),
        new Vector3(8.8f, 0f, 18.6723f),
        new Vector3(8.9f, 0f, 18.6831f),
        new Vector3(9.0f, 0f, 18.694f),
        new Vector3(9.1f, 0f, 18.7048f),
        new Vector3(9.2f, 0f, 18.7157f),
        new Vector3(9.3f, 0f, 18.7265f),
        new Vector3(9.4f, 0f, 18.7373f),
        new Vector3(9.5f, 0f, 18.7482f),
        new Vector3(9.6f, 0f, 18.759f),
        new Vector3(9.7f, 0f, 18.7699f),
        new Vector3(9.8f, 0f, 18.7807f),
        new Vector3(9.9f, 0f, 18.7916f),
        new Vector3(10.0f, 0f, 18.8024f),
        new Vector3(10.1f, 0f, 18.8133f),
        new Vector3(10.2f, 0f, 18.8241f),
        new Vector3(10.3f, 0f, 18.8349f),
        new Vector3(10.4f, 0f, 18.8458f),
        new Vector3(10.5f, 0f, 18.8566f),
        new Vector3(10.6f, 0f, 18.8675f),
        new Vector3(10.7f, 0f, 18.8783f),
        new Vector3(10.8f, 0f, 18.8892f),
        new Vector3(10.9f, 0f, 18.9f),
        new Vector3(10.9f, 0f, 18.9f),
        new Vector3(11.0f, 0f, 16.875f),
        new Vector3(11.1f, 0f, 14.85f),
        new Vector3(11.2f, 0f, 12.825f),
        new Vector3(11.3f, 0f, 10.8f),
        new Vector3(11.4f, 0f, 8.775f),
        new Vector3(11.5f, 0f, 6.75f),
        new Vector3(11.6f, 0f, 4.725f),
        new Vector3(11.7f, 0f, 2.7f),
        new Vector3(11.7f, 0f, 2.7f),
        new Vector3(11.8f, 0f, 2.85f)
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
        if(countPos < prm.Count){
            if(Vector3.Distance(prm[countPos], transform.position) < 1){
                countPos++;
            } else {
                Vector3 dir = Vector3.Normalize(prm[countPos] - transform.position);
                Vector3 vel = dir * speed * Time.deltaTime;
                transform.position = transform.position + vel;

                // Rotation of the agent
                angle = (0.95f*angle)+(0.05f*dir * speed);
                transform.rotation = Quaternion.LookRotation(angle, Vector3.up); 
            }
        }
    }
}
