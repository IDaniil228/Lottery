using System;
using System.Collections.Generic;

namespace DZ
{
    [Serializable]
    public class Entity
    {
        public string title;
        List<Object> subEntity = new List<Object>();
        public Entity() { }
        public Entity(string title)
        {
            this.title = title;
        }
        public List<Object> List { get { return subEntity; } }
    }
}
