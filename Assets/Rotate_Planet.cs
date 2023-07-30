using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Planet : MonoBehaviour
{
    [SerializeField][Range(-0.01f, -0.2f)] float velocity = -0.2f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, velocity, 0);
    }
}
