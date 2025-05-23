using System.Collections.Generic;
using System.IO;
using Goal_Tracker;
using Newtonsoft.Json;

public static class StorageService
{
    private const string FilePath = "goals.json";

    public static void SaveGoals(List<Goal> goals)
    {
        string json = JsonConvert.SerializeObject(goals, Formatting.Indented);
        File.WriteAllText(FilePath, json);
    }

    public static List<Goal> LoadGoals()
    {
        if (!File.Exists(FilePath))
            return new List<Goal>();

        string json = File.ReadAllText(FilePath);
        return JsonConvert.DeserializeObject<List<Goal>>(json);
    }
}
