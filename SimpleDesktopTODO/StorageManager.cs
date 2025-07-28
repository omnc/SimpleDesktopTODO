using System;
using System.Collections.Generic;
using System.Text.Json;
namespace SimpleDesktopTODO;

public class StorageManager
{
    private static string routinePath = "routine_data.json";
    private static string todoPath = "todo_data.json";
    private static string resetPath = "reset_data.json";
    public class Items
    {
        public string itemContent { get; set; }
        public bool isChecked { get; set; }
    }

    public class ResetTime
    {
        public string timeContent { get; set; }
        public bool isReset { get; set; }
        public string lastResetDate { get; set; }
    }

    public static ResetTime LoadResetTime()
    {
        if (!File.Exists(resetPath))
            return new ResetTime();

        var json = File.ReadAllText(resetPath);
        return JsonSerializer.Deserialize<ResetTime>(json) ?? new ResetTime();
    }
    public static void SaveRoutine(List<Items> data)
    {
        var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(routinePath, json);
    }
    
    public static List<Items> LoadRoutine()
    {
        if (!File.Exists(routinePath))
            return new List<Items>();

        var json = File.ReadAllText(routinePath);
        return JsonSerializer.Deserialize<List<Items>>(json) ?? new List<Items>();
    }

    public static void SaveToDo(List<Items> data)
    {
        var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(todoPath, json);
    }
    
    public static List<Items> LoadToDo()
    {
        if (!File.Exists(todoPath))
            return new List<Items>();

        var json = File.ReadAllText(todoPath);
        return JsonSerializer.Deserialize<List<Items>>(json) ?? new List<Items>();
    }

    public static void SaveTime(ResetTime time)
    {
        var json = JsonSerializer.Serialize(time, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(resetPath, json);
    }

    
}