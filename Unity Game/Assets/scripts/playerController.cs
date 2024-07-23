using UnityEngine;

public class PlayerController : Controller
{
    public KeyCode MoveForward;
    public KeyCode MoveBackward;
    public KeyCode TurnClockwise;
    public KeyCode TurnCounterClockwise;
    public KeyCode Shoot;
    // Start is called before the first frame update
    void Start()
    {
        //base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
        //base.Update();
    }
    public override void ProcessInputs()
    {
        if (Input.GetKey(MoveForward))
        {
            pawn.MoveForward();
        }

        if (Input.GetKey(MoveBackward))
        {
            pawn.MoveBackward();
        }

        if (Input.GetKey(TurnClockwise))
        {
            pawn.RotateClockwise();
        }
        if (Input.GetKey(TurnCounterClockwise))
        {
            pawn.RotateCounterClockwise();
        }
        if (Input.GetKey(Shoot))
        {
            pawn.Shoot();
        }
    }
}
