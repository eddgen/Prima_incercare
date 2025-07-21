using UnityEngine;


public class Elevation_Entry : MonoBehaviour
{
    public Collider2D[] mountainColliders;
    public Collider2D[] boundaryColliders;

    public bool firstlayer = true;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && firstlayer==true)
        {
            foreach (Collider2D mountain in mountainColliders)
            {
                mountain.enabled = false;

            }

            foreach (Collider2D boundary in boundaryColliders)
            {
                boundary.enabled = true;

            }
            collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 15;
            firstlayer = false;
        }
        else if (firstlayer==false)
        {
            
            foreach (Collider2D mountain in mountainColliders)
            {
                mountain.enabled = true;

            }

            foreach (Collider2D boundary in boundaryColliders)
            {
                boundary.enabled = false;

            }
    
            collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 5;
            firstlayer = true;

        }
        
    }
}
