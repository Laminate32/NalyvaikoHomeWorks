using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class EnemyChasing : MonoBehaviour
{
    public float MaxSpeed;
    private float Speed;

    private Collider[] hitColliders;
    private RaycastHit Hit;

    public float SightRange;
    public float DetectionRange;

    public Rigidbody rb;
    public GameObject Target;

    private bool seePlayer;

    public float Damage;
    public float KOTime;

    private bool CanAttack = true;

    void Start()
    {
        Speed = MaxSpeed;
    }

    
    void Update()
    {
        if (!seePlayer)
        {
            hitColliders = Physics.OverlapSphere(transform.position, DetectionRange);
            foreach (var HitCollider in hitColliders)
            {
                if (HitCollider.tag == "Player")
                {
                    Target = HitCollider.gameObject;
                    seePlayer = true;
                }
            }
        }
        else
        {
            if (Physics.Raycast(transform.position, (Target.transform.position - transform.position), out Hit, SightRange))
            {
                if(Hit.collider.tag == "Player")
                {
                    seePlayer = false;
                }
                else
                {

                    var Heading = Target.transform.position - transform.position;
                    var Distance = Heading.magnitude;
                    var Direction = Heading / Distance;

                    Vector3 Move = new Vector3(Direction.x * Speed, 0, Direction.z * Speed);
                    rb.velocity = Move;
                    transform.forward = Move;
                }
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            collision.collider.gameObject.GetComponent<Health>().TakeDamage(Damage);
            StartCoroutine(AttackDelay(KOTime));
        }
    }

    IEnumerator AttackDelay(float Delay)
    {
        Speed = 0;
        CanAttack = false;
        yield return new WaitForSeconds(Delay);
        Speed = MaxSpeed;
        CanAttack = true;
    }
}
