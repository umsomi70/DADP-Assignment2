using System.Collections;
using UnityEngine;

public class GridMovement : MonoBehaviour
{
    private bool isMoving;
    private Vector3 origPos, targetPos;
    private float timeToMove = 1f;
    OtherPlayer player;

    private void Start()
    {
        player = FindObjectOfType<OtherPlayer>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.up));
            player.MoveDown();
        }

        if (Input.GetKey(KeyCode.A) && !isMoving)
        {
            player.MoveRight();
            StartCoroutine(MovePlayer(Vector3.left));
        }

        if (Input.GetKey(KeyCode.S) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.down));
            player.MoveUp();
        }

        if (Input.GetKey(KeyCode.D) && !isMoving)
        {
            player.MoveLeft();
            StartCoroutine(MovePlayer(Vector3.right));
        }
    }

    private IEnumerator MovePlayer(Vector3 direction)
    {
        isMoving = true;

        float elapsedTime = 0;
        origPos = transform.position;
        targetPos = origPos + direction;

        while (elapsedTime < timeToMove)
        {
            transform.position = Vector3.Lerp(origPos, targetPos,( elapsedTime/ timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPos;
        isMoving = false;
    }
}
