using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public GameObject SkillSlot1, SkillSlot2, SkillSlot3;

    public GameObject SkillSpown;
    public SkillSpown skillSpown;

    public bool active;

    private void Awake()
    {
        active = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8 && skillSpown.skillCount<3)
        {
            addSkill(gameObject.tag);
            gameObject.transform.parent = SkillSpown.transform;
            gameObject.transform.localPosition = Vector2.zero;
            skillSpown.NotActiveSkills.Add(gameObject);
            active = false;
            gameObject.SetActive(false);
        }
        else if (collision.gameObject.layer == 12)
        {
            gameObject.transform.parent = SkillSpown.transform;
            gameObject.transform.localPosition = Vector2.zero;
            skillSpown.NotActiveSkills.Add(gameObject);
            active = true;
            gameObject.SetActive(false);
        }
    }

    private void addSkill(string skillTag)
    {      
        if (skillSpown.skillCount == 0)
        {
            foreach (GameObject skill in skillSpown.skills)
            {
                if (skill.tag == skillTag && skill.activeSelf==false)
                {
                    skill.SetActive(true);
                    skillSpown.ActiveSkills[0] = skill;
                    skill.transform.position = SkillSlot1.transform.position;
                    break;
                }
            }
        }
        else if (skillSpown.skillCount == 1)
        {
            foreach (GameObject skill in skillSpown.skills)
            {
                if (skill.tag == skillTag && skill.activeSelf == false)
                {
                    skill.SetActive(true);
                    skillSpown.ActiveSkills[1] = skill;
                    skill.transform.position = SkillSlot2.transform.position;
                    break;
                }
            }
        }
        else if (skillSpown.skillCount == 2)
        {
            foreach (GameObject skill in skillSpown.skills)
            {
                if (skill.tag == skillTag && skill.activeSelf == false)
                {
                    skill.SetActive(true);
                    skillSpown.ActiveSkills[2] = skill;
                    skill.transform.position = SkillSlot3.transform.position;
                    break;
                }
            }
        }
        skillSpown.skillCount++;
    }

}
