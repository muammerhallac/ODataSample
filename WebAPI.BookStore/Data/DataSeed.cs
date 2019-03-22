using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.BookStore.Models;

namespace WebAPI.BookStore.Data
{
    public class DataSeed
    {
        private static List<Value> values = new List<Value>();

        public static List<Value> GetValues()
        {
            if (!values.Any())
                GenerateValues();

            return values;
        }

        public static void UpdateValue(Value value)
        {
            if (values.Any(x=>x.Id == value.Id))
            {
                var valueTobeRemoved = values.Where(x => x.Id == value.Id).FirstOrDefault();
                values.Remove(valueTobeRemoved);
                values.Add(value);
            }
        }

        private static void GenerateValues()
        {
            var data = new List<Value>
            {
                new Value { Id = 1000, Name = "Phasellus ornare. Fusce mollis. Duis sit", IsValuable = false, CreatedOn = "02-01-19 09:01:17", AdditionalValues = new List<string>{"cereals", "noodles" } },
                new Value { Id = 1001, Name = "id, ante. Nunc", IsValuable = false, CreatedOn = "23-08-18 06:08:07", AdditionalValues = new List<string>{"pies", "stews", "sandwiches", "noodles" } },
                new Value { Id = 1002, Name = "at sem molestie sodales. Mauris blandit enim consequat purus. Maecenas libero est, congue a, aliquet vel, vulputate eu, odio. Phasellus", IsValuable = false, CreatedOn = "02-02-19 05:02:59", AdditionalValues = new List<string>{"salads", "sandwiches", "pies", "stews" } },
                new Value { Id = 1003, Name = "tortor. Nunc commodo auctor velit.", IsValuable = false, CreatedOn = "03-03-20 07:03:14", AdditionalValues =new List<string>{ "noodles", "soups","stews" } },
                new Value { Id = 1004, Name = "erat. Vivamus nisi.", IsValuable = false, CreatedOn = "03-06-19 05:06:05", AdditionalValues = new List<string>{"sandwiches", "salads", "cereals", "pies" } },
                new Value { Id = 1005, Name = "mauris elit, dictum eu, eleifend nec, malesuada ut, sem. Nulla interdum. Curabitur dictum. Phasellus in felis. Nulla tempor augue", IsValuable = false, CreatedOn = "28-04-18 10:04:41", AdditionalValues = new List<string>{"sddwe" } },
                new Value { Id = 1006, Name = "Donec fringilla. Donec feugiat", IsValuable = true, CreatedOn = "30-12-18 11:12:31", AdditionalValues = new List<string>{"desserts", "sandwiches", "soups" } },
                new Value { Id = 1007, Name = "sit amet,", IsValuable = true, CreatedOn = "19-02-19 05:02:44", AdditionalValues = new List<string>{"pies" } },
                new Value { Id = 1008, Name = "nibh lacinia orci, consectetuer euismod est arcu ac orci. Ut semper pretium neque. Morbi quis urna. Nunc quis", IsValuable = false, CreatedOn = "07-05-19 12:05:16", AdditionalValues =new List<string>{ "stews", "soups" } },
                new Value { Id = 1009, Name = "et ultrices posuere cubilia Curae; Donec tincidunt. Donec vitae", IsValuable = true, CreatedOn = "10-02-20 04:02:45", AdditionalValues = new List<string>{"pies", "sandwiches", "soups" } },
                new Value { Id = 1010, Name = "nonummy ut, molestie in, tempus eu, ligula. Aenean euismod mauris", IsValuable = true, CreatedOn = "26-11-19 09:11:49", AdditionalValues =new List<string>{ "stews", "pasta" } } };
            values = data;
        }
    }
}
