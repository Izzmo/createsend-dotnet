﻿using System;
using System.Collections.Generic;
using System.Text;
using createsend_dotnet;
using Newtonsoft.Json;

namespace ConsoleRunner
{
    class Program
    {
        //testing - 011ebcadaeb71e9a
        //testing list - aa76d29949e7f10ab28712617634fd0b
        //apicreated  - 277da11f331fc698ad22a66c0c4b5c33
        //list in apicreated - 41a99346539316727de7f24491da29d6
        static void Main(string[] args)
        {
            new Subscriber("41a99346539316727de7f24491da29d6").Add("jasonh+fromapi1@freshview.com", "Jason", new List<SubscriberCustomField>() { new SubscriberCustomField() { Key = "[aasfd]", Value = "AFADFDSF" } }, true);

        }
    }
}
