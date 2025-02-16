using UnityEngine;

public class Enemy : MonoBehaviour
{
    private IAttackStrategy attackStrategy;

    private void Start()
    {
        // Assign a default attack strategy if none is set
        if (attackStrategy == null)
            attackStrategy = new MeleeAttack();
    }

    public void SetAttackStrategy(IAttackStrategy strategy)
    {
        attackStrategy = strategy;
    }

    public void PerformAttack()
    {
        attackStrategy.Attack();
    }
}
