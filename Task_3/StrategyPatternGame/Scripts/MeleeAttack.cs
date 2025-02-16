using UnityEngine;

public class MeleeAttack : IAttackStrategy
{
    public void Attack()
    {
        Debug.Log("Enemy attacks with melee!");
        Player.Instance.TakeDamage(10);
    }
}
