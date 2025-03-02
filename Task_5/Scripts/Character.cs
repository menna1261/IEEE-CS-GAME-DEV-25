using UnityEngine;

public class Character : MonoBehaviour
{
    public int _health;
    public int _AttackPower;
    public int _takeDamage;
    public bool isInQueue = true;

    // Initialize character
    public void Init(int health, int attackPower, int takeDamage)
    {
        _health = health;
        _AttackPower = attackPower;
        _takeDamage = takeDamage;
    }

    // Take damage logic
    public void TakeDamage()
    {
        _health -= _takeDamage;
        if (_health <= 0)
        {
            isInQueue = false;
            Debug.Log(gameObject.name + " has died!");
            Destroy(gameObject);
        }
    }

    public bool isDead()
    {
        return _health <= 0;
    }
}
