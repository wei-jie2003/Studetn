﻿namespace WebApplication2.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        ///<summary>
        ///主修科目
        ///</summary>
        public string Major { get; set; }
        public string Email { get; set; }
    }
}
