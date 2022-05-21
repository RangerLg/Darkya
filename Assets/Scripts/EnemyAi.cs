using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{

    [SerializeField] private Transform point1;
    [SerializeField] private Transform point2;

    [SerializeField] private GameObject enemy;
    private SpriteRenderer sprite;
    private bool isForward = false;
    // Start is called before the first frame update
    void Start()
    {
        sprite = enemy.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isForward)
        {
            enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, point2.position, Time.deltaTime * 1);
        }
        else
        {
            enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, point1.position, Time.deltaTime * 1);
        }

        if (enemy.transform.position == point1.position || enemy.transform.position == point2.position)
        {
            isForward = !isForward;
            sprite.flipX = !sprite.flipX;
        }

    }
}
