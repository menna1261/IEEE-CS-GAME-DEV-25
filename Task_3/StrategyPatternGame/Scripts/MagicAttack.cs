using UnityEngine;

public class MagicAttack : IAttackStrategy
{
    public void Attack()
    {
        Debug.Log("Enemy casts a magic spell!");
        Player.Instance.TakeDamage(15);
    }
}
