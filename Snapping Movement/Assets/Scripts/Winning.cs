using UnityEngine;

public class Winning : MonoBehaviour
{
    public GameObject panel;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            panel.SetActive(true);
        }
    }
}
