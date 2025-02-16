using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] enemies;

    private void Start()
    {
        foreach (var enemy in enemies)
        {
            var enemyComponent = enemy.GetComponent<Enemy>();

            // Set different attack strategies
            if (enemy.name.Contains("Melee"))
            {
                enemyComponent.SetAttackStrategy(new MeleeAttack());
            }
            else if (enemy.name.Contains("Ranged"))
            {
                enemyComponent.SetAttackStrategy(new RangedAttack());
            }
            else if (enemy.name.Contains("Magic"))
            {
                enemyComponent.SetAttackStrategy(new MagicAttack());
            }

            
            enemyComponent.PerformAttack();
        }
    }
}
