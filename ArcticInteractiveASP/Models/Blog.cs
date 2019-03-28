using System;
using System.Collections.Generic;

using System.Web;

/// <summary>
/// Summary description for Blog
/// </summary>
public class Blog
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public DateTime Created { get; set; }
}