using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Attack : MonoBehaviour
{
    public float damage = 10f; // ʳ������ ���������, �� �������� �����
    public float attackRange = 1.5f; // ��������� �����
    public LayerMask targetLayer; // ���, �� ����� ����������� ������ ��'����
    public float attackRate = 15f;
    private float nextAttackTime = 5f;

    void Update()
    {
        // �������� ���������� ��� ������ ���� ��� �����
        if (Input.GetMouseButtonDown(0) && Time.time >= nextAttackTime)
        {
            PerformAttack();
            nextAttackTime = Time.time + 1f / attackRate;
        }
    }

    void PerformAttack()
    {
        // ����������� ��� ��'���� � ����� �����
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, attackRange, targetLayer);
        foreach (var hitCollider in hitColliders)
        {
            // ��������� ���������� Health � ��������� ��'����
            Health targetHealth = hitCollider.GetComponent<Health>();
            if (targetHealth != null)
            {
                // ��������� ���������
                targetHealth.TakeDamage(damage);
            }
        }
    }
}