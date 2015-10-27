using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float vmaxspeed = 0.4f;
    public float xmaxspeed = 0.2f;
    private Vector3 directionspeed;
    private float vspeed = 0.0f;
    private float xspeed = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // Max Speed control
        if(directionspeed.y >= vmaxspeed)
        {
            directionspeed.y = vmaxspeed;
        }else if (directionspeed.y <= vmaxspeed*-1)
        {
            directionspeed.y = vmaxspeed*-1;
        }

        if (directionspeed.x >= xmaxspeed)
        {
            directionspeed.x = xmaxspeed;
        }
        else if (directionspeed.x <= xmaxspeed * -1)
        {
            directionspeed.x = xmaxspeed * -1;
        }

        if (Input.anyKey) {
            Debug.Log("Vertical speed is " + directionspeed.y.ToString());
            Debug.Log("Horizontal speed is " + directionspeed.y.ToString());
            vspeed = Time.deltaTime * Input.GetAxis("Forward");
            xspeed = Time.deltaTime * Input.GetAxis("Strafe");
            directionspeed.y += vspeed;
            directionspeed.x += xspeed;
            
        }
        else
        {
            vspeed = 0.0f;
            xspeed = 0.0f;
            if (directionspeed.y > 0f)
            {
                directionspeed.y -= 0.2f * Time.deltaTime;
            }
            else if (directionspeed.y < 0f)
            {
                directionspeed.y += 0.2f * Time.deltaTime;
            }

            if (directionspeed.x > 0f)
            {
                directionspeed.x -= 0.2f * Time.deltaTime;
            }
            else if (directionspeed.x < 0f)
            {
                directionspeed.x += 0.2f * Time.deltaTime;
            }
        }
        

        transform.Translate(directionspeed);

    }
}
