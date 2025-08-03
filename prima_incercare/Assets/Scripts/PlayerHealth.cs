using UnityEngine;

public class PlayerHealth : MonoBehaviour

{
    public int currentHealth;
    public int maxHealth = 10;

    public SpriteRenderer playerSr;
    public PlayerMovement playerMovement;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void ChangeHealth(int amount)
    {

        currentHealth += amount;

        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
