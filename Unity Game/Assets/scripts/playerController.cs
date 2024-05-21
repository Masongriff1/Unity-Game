using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : controller
{
    public KeyCode MoveForward;
    public KeyCode MoveBackward;
    public KeyCode TurnClockwise;
    public KeyCode TurnCounterClockwise;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        processInputs();
    }
    public abstract void processInputs()
    {
        if (Input.GetKey(MoveForward))
        {
            pawn.MoveForward;
        }

        if (Input.GetKey(MoveBackward))
        {
            pawn.MoveBackward;
        }

        if (Input.GetKey(TurnClockwise))
        {
            pawn.RotateClockwise;
        }
        if (Input.GetKey(TurnCounterClockwise))
        {
            pawn.RotateCounterClockwise;
        }
    }
}
