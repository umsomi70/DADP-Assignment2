using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 yPos;
    public float offset = 1;

    OtherPlayer player;

    void Start()
    {
        player = FindObjectOfType<OtherPlayer>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            yPos = new Vector2(transform.position.x, transform.position.y + offset);
            transform.position = yPos;
            player.MoveUp();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            yPos = new Vector2(transform.position.x, transform.position.y - offset);
            transform.position = yPos;
            player.MoveDown();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            yPos = new Vector2(transform.position.x - offset, transform.position.y);
            transform.position = yPos;
            player.MoveLeft();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            yPos = new Vector2(transform.position.x + offset, transform.position.y);
            transform.position = yPos;
            player.MoveRight();
        }
    }
}
