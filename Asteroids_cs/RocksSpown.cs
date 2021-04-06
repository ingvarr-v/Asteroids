using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocksSpown : MonoBehaviour
{

    public List<GameObject> rocks;

    public List<GameObject> notFloatingRocks;

    private bool rockCanSpown = false;

    public bool SplitTime = true;

    public List<GameObject> SplitRocks;

    void Start()
    {
        foreach(GameObject rock in rocks)
        {
            rock.SetActive(false);
        }

        SplitTime = true;

        notFloatingRocks.AddRange(rocks.ToArray());
    }

    void Update()
    {
        if (!rockCanSpown && notFloatingRocks.Count > 0) 
        {
            StartCoroutine(RockSpownCour(2f));
        }

        if (!SplitTime)
        {
            StartCoroutine(RockSplitWait(SplitRocks));
        }
    }

    private IEnumerator RockSpownCour(float time)
    {
        rockCanSpown = true;
        yield return new WaitForSeconds(time);

        Vector2 direction = (Vector2.zero - (Vector2)transform.position).normalized;
        int randomRotationOffset = Random.Range(-45, 45);
        transform.up = direction;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z + randomRotationOffset);

        if (Random.Range(1, 5) == 1)
        {
            int randomRock = Random.Range(0, notFloatingRocks.Count - 1);

            bool RockSpownCan = true;
            foreach(GameObject ChildRock in notFloatingRocks[randomRock].GetComponent<AsteroidManager>().ChildRocks)
            {
                if(ChildRock.GetComponent<AsteroidManager>().Ready != true)
                {
                    rockCanSpown = false;
                }
            }
            if (RockSpownCan)
            {
                GameObject currentRock = notFloatingRocks[randomRock];
                notFloatingRocks.Remove(currentRock);
                currentRock.SetActive(true);
                currentRock.transform.parent = null;
                currentRock.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                int rockVelocity = Random.Range(5, 15);
                currentRock.GetComponent<Rigidbody2D>().AddForce(transform.up * rockVelocity);
            }
        }

        rockCanSpown = false;
    }
    

    public IEnumerator RockSplitWait(List<GameObject> ChildRocks)
    {
        SplitTime = true;

        foreach(GameObject rock in ChildRocks)
        {
            rock.layer = 13;
        }

        yield return new WaitForSeconds(1f);

        foreach (GameObject rock in ChildRocks)
        {
            rock.layer = 10;
        }

        SplitRocks.Clear();

        SplitTime = true;
    }
}
