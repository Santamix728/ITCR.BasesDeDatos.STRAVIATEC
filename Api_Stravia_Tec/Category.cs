﻿namespace Api_Stravia_Tec
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Activity> Activity { get; set; }

    }
}
