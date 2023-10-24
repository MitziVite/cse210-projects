using System.Text.RegularExpressions;

public class Word
{
    private string _word;
    private bool _isHidden = false;
    public Word(string word){
        _word = word;
    }
    public override string ToString()
    {
        return _isHidden ? Regex.Replace(_word, "[a-zA-Z]", "_") : _word;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public void Hide()
    {
        _isHidden = true;
    }

}