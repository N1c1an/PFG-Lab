using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] private float jump = 5f;

    private float walkingspeed = 5f;

    private Vector2 move;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        Inputs.Init(this);
    }



    public void setlook(Vector2 w)
    {

    }

    public void MoveTo(Vector2 s)
    {
        move = s;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * (move.y * Time.deltaTime) * walkingspeed, Space.Self);
        transform.Translate(Vector3.right * (move.x * Time.deltaTime) * walkingspeed, Space.Self);
        
    }
}
