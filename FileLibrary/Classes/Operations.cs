﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FileLibrary.Models;

namespace FileLibrary.Classes
{
    public class Operations
    {
        /// <summary>
        /// File name to read <see cref="Person"/> from
        /// </summary>
        public static string PeopleFileName = 
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "People.json");

        /// <summary>
        /// Read list of <see cref="Person"/> from json file
        /// </summary>
        /// <returns>List of Person</returns>
        public static List<Person> ReadPeople() 
            => JsonSerializer.Deserialize<List<Person>>(File.ReadAllText(PeopleFileName));

    }
}
