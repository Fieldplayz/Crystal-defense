using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalHealth : MonoBehaviour
{
    public Slider healthBar;

    [Range(0.1f, 10f)]
    public float maxHealth = 10f;

    public float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.value = currentHealth;
    }

    public void TakeDamage(float amount)
    {

    }
}
