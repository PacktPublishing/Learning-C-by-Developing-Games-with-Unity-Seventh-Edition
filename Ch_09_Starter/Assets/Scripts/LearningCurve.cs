using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    private int CurrentAge = 30;
    public int AddedAge = 1;

    public float Pi = 3.14f;
    public string FirstName = "Harrison";
    public bool IsAuthor = true;

    public int CurrentGold = 32;

    public bool PureOfHeart = true;
    public bool HasSecretIncantation = false;
    public string RareItem = "Relic Stone";

    public string CharacterAction = "Attack";

    public int DiceRoll = 7;
    public int PlayerLives = 3;

    public Transform CamTransform;
    public GameObject DirectionLight;
    public Transform LightTransform;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(30 + 1);
        Debug.Log(CurrentAge + 1);

        ComputeAge();
        Debug.Log($"A string can have variables like {FirstName} inserted directly!");

        int CharacterLevel = 32;
        int NextSkillLevel = GenerateCharacter("Spike", CharacterLevel);
        Debug.Log(NextSkillLevel);
        Debug.Log(GenerateCharacter("Faye", CharacterLevel));

        Thievery();
        OpenTreasureChamber();
        PrintCharacterAction();
        RollDice();
        FindPartyMember();

        Dictionary<string, int> ItemInventory = new Dictionary<string, int>()
        {
            { "Potion", 5 },
            { "Antidote", 7 },
            { "Aspirin", 1 }
        };

        Debug.LogFormat("Items: {0}", ItemInventory.Count);

        HealthStatus();

        Character hero = new Character();
        Character villain = hero;
        villain.name = "Sir Kane the Bold";
        hero.PrintStatsInfo();
        villain.PrintStatsInfo();

        Character heroine = new Character("Agatha");
        heroine.PrintStatsInfo();

        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        Weapon warBow = huntingBow;
        warBow.name = "War Bow";
        warBow.damage = 155;
        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();

        Paladin knight = new Paladin("Sir Arthur", huntingBow);
        knight.PrintStatsInfo();

        CamTransform = this.GetComponent<Transform>();
        Debug.Log(CamTransform.localPosition);

        //DirectionLight = GameObject.Find("Directional Light");
        LightTransform = DirectionLight.GetComponent<Transform>();
        Debug.Log(LightTransform.localPosition);
    }

    /// <summary>
    /// A method to compute two variables
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
    }

    public int GenerateCharacter(string name, int level)
    {
        return level += 5;
    }

    public void Thievery()
    {
        if (CurrentGold > 50)
        {
            Debug.Log("You're rolling in it!");
        }
        else if (CurrentGold < 15)
        {
            Debug.Log("Not much there to steal...");
        }
        else
        {
            Debug.Log("Looks like your purse is in the sweet spot.");
        }
    }

    public void OpenTreasureChamber()
    {
        if (PureOfHeart && RareItem == "Relic Stone")
        {
            if (!HasSecretIncantation)
            {
                Debug.Log("You have the spirit, but not the knowledge.");
            }
            else
            {
                Debug.Log("The treasure is yours, worthy hero!");
            }
        }
        else
        {
            Debug.Log("Come back when you have what it takes.");
        }
    }

    public void PrintCharacterAction()
    {
        switch (CharacterAction)
        {
            case "Heal":
                Debug.Log("Potion sent.");
                break;
            case "Attack":
                Debug.Log("To arms!");
                break;
            default:
                Debug.Log("Shields up.");
                break;
        }
    }

    public void RollDice()
    {
        switch(DiceRoll)
        {
            case 7:
            case 15:
                Debug.Log("Mediocre damage, not bad.");
                break;
            case 20:
                Debug.Log("Critical hit, the creature goes down!");
                break;
            default:
                Debug.Log("You completely missed and fell on your face.");
                break;
        }
    }

    public void FindPartyMember()
    {
        List<string> QuestPartyMembers = new List<string>()
        {
            "Grim the Barbarian",
            "Merlin the Wise",
            "Sterling the Knight"
        };
        int listLength = QuestPartyMembers.Count; 

        QuestPartyMembers.Add("Craven the Necromancer");
        QuestPartyMembers.Insert(1, "Tanis the Thief");
        QuestPartyMembers.RemoveAt(0);
        //QuestPartyMembers.Remove("Grim the Barbarian");

        Debug.LogFormat("Party Members: {0}", listLength);

        for (int i = 0; i < listLength; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMembers[i]);

            if (QuestPartyMembers[i] == "Merlin the Wise")
            {
                Debug.Log("Glad you're here Merlin!");
            }
        }
    }

    public void HealthStatus()
    {
        while (PlayerLives > 0)
        {
            Debug.Log("Still alive!");
            PlayerLives--;
        }

        Debug.Log("Player KO'd...");
    }
}