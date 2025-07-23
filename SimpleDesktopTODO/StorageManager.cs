using System;
using System.Collections.Generic;
using System.Text.Json;
namespace SimpleDesktopTODO;

public class StorageManager
{
    public class Items
    {
        public string itemContent { get; set; }
        public bool isChecked { get; set; }
    }
    
    public class AppData
    {
        public List<Items> List1 { get; set; } = new();
        public List<Items> List2 { get; set; } = new();
    }

    private static string filePath = "todo_data.json";

    public static void Save(AppData data)
    {
        var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }

    public static AppData Load()
    {
        if (!File.Exists(filePath))
            return new AppData();

        var json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<AppData>(json);
    }
    
}