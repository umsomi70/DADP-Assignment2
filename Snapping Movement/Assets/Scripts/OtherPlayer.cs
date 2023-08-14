using UnityEngine;
using System.Collections;

public class OtherPlayer : MonoBehaviour
{
    private Vector3 origPos, targetPos;
    private float timeToMove = 1f;

    public void MoveUp()
    {
        StartCoroutine(MovePlayer(Vector3.up));
    }

    public void MoveDown()
    {
        StartCoroutine(MovePlayer(Vector3.down));
    }

    public void MoveRight()
    {
        StartCoroutine(MovePlayer(Vector3.right));
    }

    public void MoveLeft()
    {
        StartCoroutine(MovePlayer(Vector3.left));
    }

    private IEnumerator MovePlayer(Vector3 direction)
    {

        float elapsedTime = 0;
        origPos = transform.position;
        targetPos = origPos + direction;

        while (elapsedTime < timeToMove)
        {
            transform.position = Vector3.Lerp(origPos, targetPos, (elapsedTime / timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPos;
    }
}
