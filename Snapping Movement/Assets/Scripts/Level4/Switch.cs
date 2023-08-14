using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject []spike;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            for(int i = 0; i< spike.Length;i++)
            {
                spike[i].SetActive(false);
            }    
        }
    }
}
