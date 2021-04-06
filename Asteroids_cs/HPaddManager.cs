using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPaddManager : MonoBehaviour
{
    public PlayerManager playerMan;

    public SkillSpown skillSpown;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            if (playerMan.HP <= 10)
            {
                playerMan.HP++;
                playerMan.getHealth(playerMan.HP);

                gameObject.transform.parent = skillSpown.transform;
                gameObject.transform.localPosition = Vector2.zero;
                skillSpown.NotActiveSkills.Add(gameObject);
                gameObject.SetActive(false);
            }
        }
        else if (collision.gameObject.layer == 12)
        {
            gameObject.transform.parent = skillSpown.transform;
            gameObject.transform.localPosition = Vector2.zero;
            skillSpown.NotActiveSkills.Add(gameObject);
            gameObject.SetActive(false);
        }
    }
}
