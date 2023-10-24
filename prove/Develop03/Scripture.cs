using System;
using System.Collections.Generic;
public class Scripture
{
    private List <Word> _scripture = new List<Word>();
    public Scripture(string scriptureText)
    {
        foreach (string word in scriptureText.Split(' '))
        {
            _scripture.Add(new Word(word));
        }
    }
    public void Display()
    {
        foreach (var word in _scripture)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        Random rnd = new Random();
        int index = rnd.Next(_scripture.Count);
        while (_scripture[index].IsHidden())  
    {
        index = rnd.Next(_scripture.Count);
    }
        _scripture[index].Hide();
    }

    public bool AllWordsHidden()
    {
        foreach (var word in _scripture)
        {
            if (!word.IsHidden())
                return false;
            }
        return true;
    }
}