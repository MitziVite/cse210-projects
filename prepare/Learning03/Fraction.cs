using System;
using System.Collections.Generic;
using System.IO;
public class Fraction
{
    private int _top;
    private int _bottom;

    public int GetTop(){
        return _top;
    }

    public int GetBottom(){
        return _bottom;
    }

    public void SetFraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }
}