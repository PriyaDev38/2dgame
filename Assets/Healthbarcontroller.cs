using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class HealthBarController : MonoBehaviour
{
    public Image healthBar; // This is your health bar image
    public float maxHealth = 100f; // Total health
    private float currentHealth;

    void Start()
    {
        currentHealth = maxHealth; // Start with full health
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage; // Reduce health when taking damage
        UpdateHealthBar(); // Update the health bar to reflect the new health
    }

    void UpdateHealthBar()
    {
        healthBar.fillAmount = currentHealth / maxHealth; // Shrink the bar as health goes down
    }
}