using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int _health;
    private float _speed;

    public void Initialize(int helath, float speed)
    {
        _health = helath;
        _speed = speed;

        Debug.Log($"��: {_health}, ��������: {_speed}");
    }  
}
