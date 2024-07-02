using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Attack : MonoBehaviour
{
    public float damage = 10f; // Кількість ушкоджень, які наносить атака
    public float attackRange = 1.5f; // Дистанція атаки
    public LayerMask targetLayer; // Шар, на якому знаходяться цільові об'єкти
    public float attackRate = 15f;
    private float nextAttackTime = 5f;

    void Update()
    {
        // Перевірка натискання лівої кнопки миші для атаки
        if (Input.GetMouseButtonDown(0) && Time.time >= nextAttackTime)
        {
            PerformAttack();
            nextAttackTime = Time.time + 1f / attackRate;
        }
    }

    void PerformAttack()
    {
        // Знаходження всіх об'єктів у радіусі атаки
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, attackRange, targetLayer);
        foreach (var hitCollider in hitColliders)
        {
            // Отримання компонента Health у цільового об'єкта
            Health targetHealth = hitCollider.GetComponent<Health>();
            if (targetHealth != null)
            {
                // Нанесення ушкоджень
                targetHealth.TakeDamage(damage);
            }
        }
    }
}