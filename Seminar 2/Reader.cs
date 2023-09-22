using System;

public static class Reader
{
    bool IsUserExists(string path, string login, string password, string adress) {
        string[] lines = File.ReadAllLines("test.txt");
        foreach (string s in lines)
        {
            string[] data = s.Split(' ');
            if (data.Length() == 3 && data[0] == login && data[1] == password && data[2] == adress)
                return true;
        }
        return false;
    }   
}
