﻿namespace DevOpsDemo.Model;
public class DevOpsInfo
{
    public IEnumerable<string> Pratices { get; set; }
    
    public IEnumerable<string> Contributers { get; set; }

    public string? ClassName { get; set; }

    public State ProjectState { get; set; }
}