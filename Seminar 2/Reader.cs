using System;

public static class Reader
{
    public static bool IsUserExists(string path, string login, string password) {
        string[] lines = File.ReadAllLines("test.txt");
        foreach (string s in lines)
        {
            string[] data = s.Split(' ');
            if (data.Length == 2 && data[0] == login && data[1] == password)
                return true;
        }
        return false;
    }   
}
