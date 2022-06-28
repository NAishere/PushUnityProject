using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteOffsetter : MonoBehaviour
{
    public Vector3 offset = new Vector3(0.03125f, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {

        Debug.Log(RoundPixel(transform.parent.position) - transform.parent.position);

        transform.localPosition = (RoundPixel(transform.parent.position) - transform.parent.position + offset);
    }

    Vector3 RoundPixel(Vector3 input)
    {
        input *= 16;
        input.x = Mathf.Round(input.x);
        input.y = Mathf.Round(input.y);
        input /= 16;
        return input;
    }
}
