using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public string PlayerName;
    public List<string> BestPlayerName= new List<string>(5);
    public List<int> Points =new List<int>(5);
    // Start is called before the first frame update


    private void Awake()
    {
        
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        LoadJson();
        Instance = this;
        DontDestroyOnLoad(gameObject);
        for(int i = 0; i < BestPlayerName.Count; i++)
        {
            if (BestPlayerName[i] == null)
            {
                BestPlayerName[i] = "";
            }


        }
    }

    [SerializeField]
    public class SaveData
    {
        public List<string> PlayerName = new List<string>(5);
        public List<int> Points = new List<int>(5);
    }

    public void SaveJson()
    {
        SaveData a = new SaveData();
        a.PlayerName = BestPlayerName;
        a.Points = Points;
        string json = JsonUtility.ToJson(a);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadJson()
    {
        string json = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(json))
        {
            json = File.ReadAllText(json);
            SaveData a = JsonUtility.FromJson<SaveData>(json);
            BestPlayerName = a.PlayerName;
            Points = a.Points;
        }
    }

}
