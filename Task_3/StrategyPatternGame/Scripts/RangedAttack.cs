using UnityEngine;

public class RangedAttack : IAttackStrategy
{
    public void Attack()
    {
        Debug.Log("Enemy attacks with a ranged projectile!");
        Player.Instance.TakeDamage(5);
    }
}
