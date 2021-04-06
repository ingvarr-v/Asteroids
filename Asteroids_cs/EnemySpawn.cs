using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public List<GameObject> Enemies;

    public List<GameObject> NotActiveEnemy;

    private bool EnemyCanSpown=false;

    public float enemyCount = 0f;

    void Start()
    {
        NotActiveEnemy.AddRange(Enemies.ToArray());

        foreach(GameObject alien in Enemies)
        {
            alien.SetActive(false);
        }
    }

    void Update()
    {
        if (!EnemyCanSpown)
        {
            StartCoroutine(EnemySpownWait(3f));
        }

    }

    private IEnumerator EnemySpownWait(float time)
    {
        EnemyCanSpown = true;

        yield return new WaitForSeconds(time);
        if (Random.Range(1, 3) == 1)
        {
            if (enemyCount < 3)
            {
                enemyCount++;
                int randomEnemy = Random.Range(0, NotActiveEnemy.Count - 1);
                GameObject currentEnemy = NotActiveEnemy[randomEnemy];
                currentEnemy.SetActive(true);
                currentEnemy.GetComponent<EnemyManager>().ActiveEnemie = true;
                currentEnemy.GetComponent<EnemyManager>().canFire = false;
                currentEnemy.transform.parent = null;
                currentEnemy.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                NotActiveEnemy.Remove(currentEnemy);
            }
        }

        EnemyCanSpown = false;
    }
}
