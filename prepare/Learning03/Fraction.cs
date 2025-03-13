
using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
class Fraction
{
    private int _top = 1;
    private int _bottom = 1;
    
    public int GetTop()
    {
        return _top;
    }
    
    public int GetBottom()
    {
        return _bottom;
    }
    
    public void SetTop(int top)
    {
        _top = top;
    }
    
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    
    public string GetFractionString()
    {
        string _fraction = _top + "/" + _bottom;
        return _fraction; 
    }
    
    public double GetFraction()
    {
        double _fraction = (double)_top/_bottom;
        return _fraction;
    }
}