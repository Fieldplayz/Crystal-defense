using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalHealth : MonoBehaviour
{
    [Header("Health Bar :")]
    public Slider healthBar;

    [Header("Max Health Amount :")]
    [Range(0.1f, 10f)]
    public float maxHealth;

    [Header("Enemy Damage Amount :")]
    [Range(0.1f, 5f)]
    public float enemyDamageValue;

    [Header("Damage Cooldown Time :")]
    [Range(0.1f, 5f)]
    public float damageCooldownTime;

    public float currentHealth;
    public bool isDamageable;

    private void Start()
    {
        isDamageable = true;
        currentHealth = maxHealth;
        healthBar.value = currentHealth;
    }

    IEnumerator TakeDamage(float damage)
    {
        isDamageable = false;
        yield return new WaitForSeconds(damageCooldownTime);
        currentHealth -= damage;
        healthBar.value = currentHealth;
        isDamageable = true;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(enemyDamageValue);
        }
    }
}
